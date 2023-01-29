using ActivityStreams.Common.Models;
using ActivityStreams.Utilities.Helpers;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Utilities.Converters;

/// <summary>
/// Converters for serializing to/from <see cref="DateTimeXsd"/>
/// </summary>
public class DateTimeConverter : JsonConverter<DateTimeXsd>
{
    /// <summary>
    /// Convert a serialized <c>string</c> to the <see cref="DateTimeXsd"/> it represents
    /// </summary>
    public override DateTimeXsd? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            var stringValue = reader.GetString();
            if (JsonConverterHelper.IsEmpty(stringValue))
            {
                return null;
            }
            return new DateTimeXsd(stringValue!);
        }
        catch (Exception ex) 
        {
            throw new SerializationException($"Unable to deserialize to {nameof(DateTimeXsd)}", ex);
        }
    }

    /// <summary>
    /// Convert a <see cref="DateTimeXsd"/> to a serialized <c>string</c>
    /// </summary>
    public override void Write(
        Utf8JsonWriter writer,
        DateTimeXsd? dateTimeValue,
        JsonSerializerOptions options)
    {
        if (dateTimeValue is null)
        {
            writer.WriteNullValue();
        }
        else
        {
            // TODO ensure XSD is enforced either on the model or here
            writer.WriteStringValue(dateTimeValue.ToString());
        }
    }

}
