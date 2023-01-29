using ActivityStreams.Common.Models;
using ActivityStreams.Utilities.Converters;
using FluentAssertions;
using System.Text;
using System.Text.Json;

namespace ActivityStreams.UnitTests.Serialization;

// TODO this needs some heavy testing. I may not have fully understood the specification.
public class RdfLangStringTests
{
    // Rather than using SerializationOptions.Options, these tests use only the converter under test
    private static readonly JsonSerializerOptions _options = new()
    {
        Converters =
        {
            new RdfLangStringConverter()
        }
    };

    [Theory]
    [InlineData("\"a simple un-formatted string\"")]
    [InlineData("\"A <em>simple</em> note\"")]
    [InlineData("\"## A simple note\\nA simple markdown `note`\"")]
    [InlineData("{\r\n    \"en\": \"A simple note\",\r\n    \"es\": \"Una nota sencilla\",\r\n    \"zh-Hans\": \"一段简单的笔记\"\r\n  }")]
    [InlineData("{\r\n    \"en\": \"A <em>simple</em> note\",\r\n    \"es\": \"Una nota <em>sencilla</em>\",\r\n    \"zh-Hans\": \"一段<em>简单的</em>笔记\"\r\n  }")]
    public async Task GivenValidRdfLangString_WhenDeserialised_ThenSucceeds(string input)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(input));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<RdfLangString>(stream, _options);

        // Assert
        sut.Should()
            .NotBeNull().And
            .BeOfType<RdfLangString>();
    }

    [Theory]
    [InlineData("\" \"")]
    [InlineData("\"\"")]
    [InlineData("\"{}\"")]
    [InlineData("{\n    \n}")]
    public async Task GivenEmptyRdfLangString_WhenDeserialised_ThenReturnsNull(string date)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(date));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<RdfLangString>(stream, _options);

        // Assert
        sut.Should().BeNull();
    }
}
