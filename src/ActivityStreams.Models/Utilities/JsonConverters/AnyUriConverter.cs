using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Types;
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
            if (JsonElement.TryParseValue(ref reader, out JsonElement? jElement))
            {
                switch (jElement!.Value.ValueKind)
                {
                    case JsonValueKind.String:
                        {
                            var stringValue = reader.GetString();
                            if (string.IsNullOrWhiteSpace(stringValue) ||
                                stringValue.Equals("{}") || stringValue.Equals("{ }"))
                            {
                                return null;
                            }
                            return new AnyUri(stringValue);
                        }
                    case JsonValueKind.Object:
                        {
                            var valuesToDeserialiseFrom = jElement.Value.EnumerateObject().ToDictionary(x => x.Name, x => x.Value);
                            if (valuesToDeserialiseFrom.Count == 0)
                            {
                                return null;
                            }

                            var href = valuesToDeserialiseFrom.ContainsKey("href") ? JsonSerializer.Deserialize<Uri?>(valuesToDeserialiseFrom["href"], options) : null;
                            if (href == null)
                            {
                                return null;
                            }

                            var type = valuesToDeserialiseFrom.ContainsKey("type") ? JsonSerializer.Deserialize<ObjectType?>(valuesToDeserialiseFrom["type"], options) : null;

                            return new AnyUri { Type = type, Href = href };
                        }
                }
            }
            return null;
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
