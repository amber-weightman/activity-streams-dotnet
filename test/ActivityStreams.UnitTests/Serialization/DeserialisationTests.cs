using ActivityStreams.Models.Extended.Activity;
using ActivityStreams.UnitTests.Utils;
using System.Text.Json;

namespace ActivityStreams.UnitTests.Serialization;

public class DeserialisationTests
{
    [Theory]
    [InlineData("Accept_0")]
    [InlineData("Accept_1")]
    public async Task GivenValidAcceptJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        var fileLocation = FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData");
        using var reader = new StreamReader(fileLocation);
        
        // Act
        var sut = await JsonSerializer.DeserializeAsync<Accept>(reader.BaseStream);

        // Assert
        // TODO ASSERT
    }
}