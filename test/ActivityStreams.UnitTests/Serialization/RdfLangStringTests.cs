using ActivityStreams.Contract.Common;
using ActivityStreams.Models.Common;
using ActivityStreams.Models.Utilities.JsonConverters;
using FluentAssertions;
using System.Runtime.Serialization;
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
    [InlineData("{{\"en\": \"A simple note\", \"es\": \"Una nota sencilla\", \"zh-Hans\": \"一段简单的笔记\" }}")]
    [InlineData("{{\"en\": \"A simple <em>note</em>\", \"es\": \"Una <em>nota</em> sencilla\", \"zh-Hans\": \"一段<em>简单的</em>笔记\" }}")]
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
    [InlineData("\"not a date\"")]
    [InlineData("\"25/25/25\"")]
    [InlineData("\" \"")]
    public async Task GivenInvalidRdfLangString_WhenDeserialised_ThenThrowsSerializationError(string input)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(input));

        // Act
        Func<Task> act = async () => await JsonSerializer.DeserializeAsync<RdfLangString>(stream, _options);

        // Assert
        await act.Should().ThrowAsync<SerializationException>()
            .WithMessage("Unable to deserialize");
    }

    [Theory]
    [InlineData("\"\"")]
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
