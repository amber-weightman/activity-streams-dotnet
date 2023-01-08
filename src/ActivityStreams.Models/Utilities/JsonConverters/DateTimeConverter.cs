using ActivityStreams.Contract.Common;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Utilities.JsonConverters;

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
            if (string.IsNullOrEmpty(stringValue))
            {
                return null;
            }
            return new DateTimeXsd(stringValue);
        }
        catch (ArgumentException ex)
        {
            throw new SerializationException("Unable to deserialize invalid or unrecognised date", ex);
        }
        catch (Exception ex) 
        {
            // "This can't happen" :P
            throw new SerializationException("Unable to deserialize", ex);
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
        if (dateTimeValue == null)
        {
            writer.WriteNullValue();
        }
        else
        {
            writer.WriteStringValue(dateTimeValue.ToString());
        }
    }

}
