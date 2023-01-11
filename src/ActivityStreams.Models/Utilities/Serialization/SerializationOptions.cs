using ActivityStreams.Models.Utilities.JsonConverters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Utilities.Serialization;

/// <summary>
/// Recommended serialization settings
/// </summary>
public static class SerializationOptions
{
    /// <summary>
    /// Recommended <see cref="JsonSerializerOptions"/> settings
    /// </summary>
    public static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Converters =
        {
            new JsonStringEnumConverter(),
            new CoreTypeConverter(),
            new DateTimeConverter(),
            new RdfLangStringConverter(),
            new AnyUriConverter()
        }
    };
}
