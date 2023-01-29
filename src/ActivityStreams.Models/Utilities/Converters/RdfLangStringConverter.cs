using ActivityStreams.Common.Models;
using ActivityStreams.Utilities.Helpers;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Utilities.Converters;

/// <summary>
/// Converters for serializing to/from <see cref="RdfLangString"/>
/// </summary>
internal class RdfLangStringConverter : JsonConverter<RdfLangString>
{
    /// <summary>
    /// Convert a serialized <c>string</c> to the <see cref="RdfLangString"/> it represents
    /// </summary>
    public override RdfLangString? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            if (!JsonElement.TryParseValue(ref reader, out JsonElement? jElement))
            {
                return null;
            }

            switch (jElement.Value.ValueKind)
            {
                case JsonValueKind.String:
                    var stringValue = reader.GetString();
                    if (JsonConverterHelper.IsEmpty(stringValue))
                    {
                        return null;
                    }
                    return new RdfLangString { String = stringValue };

                case JsonValueKind.Object:
                    {
                        var valuesToDeserialiseFrom = jElement.Value.EnumerateObject().ToDictionary(x => x.Name, x => x.Value);
                        if (valuesToDeserialiseFrom.Count == 0)
                        {
                            return null;
                        }

                        Dictionary<string, string?>? dictionary = null;
                        var languageProps = valuesToDeserialiseFrom.Where(k => k.Key != "string" && k.Key != "mediaType").ToList();
                        if (languageProps.Count > 0)
                        {
                            dictionary = languageProps.ToDictionary(v => v.Key, v => JsonSerializer.Deserialize<string>(v.Value, options));
                        }

                        var str = valuesToDeserialiseFrom.ContainsKey("string") ? JsonSerializer.Deserialize<string?>(valuesToDeserialiseFrom["string"], options) : null;
                        var media = valuesToDeserialiseFrom.ContainsKey("mediaType") ? JsonSerializer.Deserialize<string?>(valuesToDeserialiseFrom["mediaType"], options) : null;

                        return new RdfLangString
                        {
                            String = str,
                            MediaType = media,
                            Map = dictionary
                        };
                    }
            }
            return null;
        }
        catch (Exception ex) 
        {
            throw new SerializationException($"Unable to deserialize to {nameof(RdfLangString)}", ex);
        }
    }

    /// <summary>
    /// Convert a <see cref="RdfLangString"/> to a serialized <c>string</c>
    /// </summary>
    public override void Write(
        Utf8JsonWriter writer,
        RdfLangString? dateTimeValue,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

}
