using ActivityStreams.Utilities.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Config;

/// <summary>
/// Recommended serialization settings
/// </summary>
public static class SerializationOptions
{
    /// <summary>
    /// Recommended <see cref="JsonSerializerOptions"/> settings
    /// </summary>
    public static readonly JsonSerializerOptions Default = new()
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
