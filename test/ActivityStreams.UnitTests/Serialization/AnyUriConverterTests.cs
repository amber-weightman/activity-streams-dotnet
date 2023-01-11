using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using ActivityStreams.Models.Utilities.JsonConverters;
using FluentAssertions;
using System.Text;
using System.Text.Json;

namespace ActivityStreams.UnitTests.Serialization;

// TODO this needs some heavy testing. I may not have fully understood the specification.
public class AnyUriConverterTests
{
    // Rather than using SerializationOptions.Options, these tests use only the converter under test
    private static readonly JsonSerializerOptions _options = new()
    {
        Converters =
        {
            new AnyUriConverter()
        }
    };

    [Theory]
    [InlineData("https://www.w3.org/ns/activitystreams")]
    [InlineData("https://john.doe@www.example.com:123/forum/questions/?tag=networking&order=newest#top")]
    [InlineData("ldap://[2001:db8::7]/c=GB?objectClass?one")]
    [InlineData("mailto:John.Doe@example.com")]
    [InlineData("news:comp.infosystems.www.servers.unix")]
    [InlineData("tel:+1-816-555-1212")]
    [InlineData("telnet://192.0.2.16:80/")]
    [InlineData("urn:oasis:names:specification:docbook:dtd:xml:4.1.2")]
    public async Task GivenValidAnyUriHref_WhenDeserialised_ThenSucceeds(string href)
    {
        // Arrange
        var hrefUri = new Uri(href);
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes($"\"{href}\""));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<AnyUri>(stream, _options);

        // Assert
        sut.Should().BeEquivalentTo(new AnyUri
        {
            Href = hrefUri
        });
        sut!.ToString().Should().Be(hrefUri.ToString());
    }

    [Theory]
    [InlineData(ObjectType.Unknown)]
    [InlineData(ObjectType.Object)]
    [InlineData(ObjectType.View)]
    public async Task GivenValidAnyUriType_WhenDeserialised_ThenSucceeds(ObjectType type)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes($"\"{type}\""));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<AnyUri>(stream, _options);

        // Assert
        sut.Should().BeEquivalentTo(new AnyUri
        {
            Type = type,
            Href = new Uri(type.ToString(), UriKind.Relative)
        });
        sut!.ToString().Should().Be(type.ToString());
    }

    [Theory]
    [InlineData("under your bed")]
    public async Task GivenValidAnyUriName_WhenDeserialised_ThenSucceeds(string name)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes($"\"{name}\""));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<AnyUri>(stream, _options);

        // Assert
        sut.Should().BeEquivalentTo(new AnyUri
        {
            Href = new Uri(name, UriKind.Relative)
        });
        sut!.ToString().Should().Be(name);
    }

    [Theory]
    [InlineData("\" \"")]
    [InlineData("\"\"")]
    [InlineData("\"{}\"")]
    [InlineData("{\n    \n}")]
    public async Task GivenEmptyAnyUri_WhenDeserialised_ThenReturnsNull(string date)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(date));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<AnyUri>(stream, _options);

        // Assert
        sut.Should().BeNull();
    }

    [Theory]
    [InlineData("{\r\n    \"type\": \"Audio\",\r\n    \"href\": \"https://www.w3.org/ns/activitystreams\",\r\n }")]
    public async Task GivenValidAnyUriObject_WhenDeserialised_ThenSucceeds(string input)
    {
        // Arrange
        var hrefUri = new Uri("https://www.w3.org/ns/activitystreams");
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(input));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<AnyUri>(stream, _options);

        // Assert
        sut.Should().BeEquivalentTo(new AnyUri
        {
            Type = ObjectType.Audio,
            Href = hrefUri
        });
        sut!.ToString().Should().Be(hrefUri.ToString());
    }
}
