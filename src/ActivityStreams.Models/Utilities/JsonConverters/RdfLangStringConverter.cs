using ActivityStreams.Contract.Common;
using ActivityStreams.Models.Common;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Utilities.JsonConverters;

/// <summary>
/// Converters for serializing to/from <see cref="RdfLangString"/>
/// </summary>
public class RdfLangStringConverter : JsonConverter<RdfLangString>
{
    /// <summary>
    /// Convert a serialized <c>string</c> to the <see cref="RdfLangString"/> it represents
    /// </summary>
    public override RdfLangString? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (ArgumentException ex)
        {
            throw new SerializationException($"Unable to deserialize to {nameof(RdfLangString)}", ex);
        }
        catch (Exception ex) 
        {
            // "This can't happen" :P
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
