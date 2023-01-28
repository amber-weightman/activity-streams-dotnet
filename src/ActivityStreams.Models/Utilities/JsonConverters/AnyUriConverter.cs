using ActivityStreams.Contract.Common;
using ActivityStreams.Models.Common;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Utilities.JsonConverters;

/// <summary>
/// Converters for serializing to/from <see cref="IAnyUri"/>
/// </summary>
public class AnyUriConverter : JsonConverter<IAnyUri>
{
    /// <inheritdoc cref="JsonConverter{T}.CanConvert(Type)" />
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(IAnyUri).IsAssignableFrom(typeToConvert);
    }

    /// <summary>
    /// Convert a serialized <c>string</c> to the <see cref="IAnyUri"/> it represents
    /// </summary>
    public override IAnyUri? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            var stringValue = reader.GetString();
            if (string.IsNullOrWhiteSpace(stringValue) ||
                stringValue.Equals("{}") || stringValue.Equals("{ }"))
            {
                return null;
            }

            return new AnyUri(stringValue);
        }
        catch (Exception ex) 
        {
            throw new SerializationException($"Unable to deserialize to {nameof(IAnyUri)}", ex);
        }
    }

    /// <summary>
    /// Convert a <see cref="IAnyUri"/> to a serialized <c>string</c>
    /// </summary>
    public override void Write(
        Utf8JsonWriter writer,
        IAnyUri? anyUriValue,
        JsonSerializerOptions options)
    {
        if (anyUriValue == null)
        {
            writer.WriteNullValue();
        }
        else
        {
            writer.WriteStringValue(anyUriValue.ToString());
        }
    }
}
