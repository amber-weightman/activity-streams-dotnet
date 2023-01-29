using System.Text.Json.Serialization;

namespace ActivityStreams.Utilities.Helpers;

/// <summary>
/// Custom <see cref="JsonConverter"/> utilities and helpers
/// </summary>
public static class JsonConverterHelper
{
    /// <summary>
    /// Returns true if the given string value is null or empty or represents an empty json object.
    /// Returns false otherwise.
    /// </summary>
    public static bool IsEmpty(string? stringValue) =>
        (string.IsNullOrWhiteSpace(stringValue) ||
            stringValue.Equals("{}") || stringValue.Equals("{ }") 
            //|| stringValue.Equals("[]") // might we need this in the future?
        );
}
