using ActivityStreams.Contract.Common;
using ActivityStreams.Models.Utilities.JsonConverters;
using FluentAssertions;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace ActivityStreams.UnitTests.Serialization;

public class DateTimeConverterTests
{
    // Rather than using SerializationOptions.Options, these tests use only the converter under test
    private static readonly JsonSerializerOptions _options = new()
    {
        Converters =
        {
            new DateTimeConverter()
        }
    };

    [Theory]
    [InlineData("2016-05-10T00:00:00Z", "00:00:00")]
    [InlineData("2014-12-12T12:12:12Z", "00:00:00")]
    [InlineData("2015-01-01T06:00:00-08:00", "-08:00:00")]
    [InlineData("2023-01-08T22:34:26.560728+10:00", "10:00:00")]
    [InlineData("05/01/2008 6:00:00", "local")] // local is assumed where time zone is not specified
    [InlineData("05/01/2008 6:00:00AM +5:00", "05:00:00")]
    public async Task GivenValidDateTime_WhenDeserialised_ThenSucceeds(string date, string expectedOffset)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes($"\"{date}\""));
        if (expectedOffset == "local")
        {
            expectedOffset = DateTimeOffset.Now.Offset.ToString();
        }

        // Act
        var sut = await JsonSerializer.DeserializeAsync<DateTimeXsd>(stream, _options);

        // Assert
        sut.Should()
            .NotBeNull().And
            .BeOfType<DateTimeXsd>();

        sut!.ToString().Should()
            .NotBeEmpty().And
            .Be(date);

        sut.DateTime.DateTime.Kind.Should().Be(DateTimeKind.Unspecified);

        sut.DateTime.Offset.ToString().Should().Be(expectedOffset);
    }

    [Theory]
    [InlineData("\"not a date\"")]
    [InlineData("\"25/25/25\"")]
    public async Task GivenInvalidDateTime_WhenDeserialised_ThenThrowsSerializationError(string date)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(date));

        // Act
        Func<Task> act = async () => await JsonSerializer.DeserializeAsync<DateTimeXsd>(stream, _options);

        // Assert
        await act.Should().ThrowAsync<SerializationException>()
            .WithMessage("Unable to deserialize to DateTimeXsd");
    }

    [Theory]
    [InlineData("\"\"")]
    [InlineData("\" \"")]
    public async Task GivenEmptyDateTime_WhenDeserialised_ThenReturnsNull(string date)
    {
        // Arrange
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(date));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<DateTimeXsd>(stream, _options);

        // Assert
        sut.Should().BeNull();
    }

    // TODO XSD isn't being enforced, this is simply persisting the original date
    // Should examine the model more closely as to how this is validated/handled
    [Theory]
    [InlineData("2016-05-10T00:00:00Z")]
    [InlineData("2014-12-12T12:12:12Z")]
    [InlineData("2015-01-01T06:00:00-08:00")]
    [InlineData("2023-01-08T22:34:26.560728+10:00")]
    [InlineData("05/01/2008 6:00:00")] // local is assumed where time zone is not specified
    [InlineData("05/01/2008 6:00:00AM +5:00")]
    public async Task GivenValidDateTimeXsd_WhenSerialized_ThenReturnsValidXsdString(string date)
    {
        // Arrange
        var input = new DateTimeXsd(date);
        using MemoryStream stream = new MemoryStream();

        // Act
        await JsonSerializer.SerializeAsync(stream, input, _options);
        stream.Position = 0;
        using var sr = new StreamReader(stream);
        var result = await sr.ReadToEndAsync();
        var decodedResult = result.Replace("\\u002B", "+");

        // Assert
        decodedResult.Should().Be($"\"{date}\"");
    }
}
