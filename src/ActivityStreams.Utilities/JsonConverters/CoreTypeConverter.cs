using ActivityStreams.Contract.Core;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using ActivityStreams.Models.Core;

namespace ActivityStreams.Utilities.JsonConverters;

/// <summary>
/// 
/// </summary>
public class CoreTypeConverter : JsonConverter<ICoreType[]>
{
    /// <summary>
    /// 
    /// </summary>
    public override ICoreType[] Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var serialisedValue = reader.GetString();
        //DateTimeOffset.ParseExact(reader.GetString()!,
        //                "MM/dd/yyyy", CultureInfo.InvariantCulture);

        if (!string.IsNullOrEmpty(serialisedValue))
        {
            var x = new Core.Object();
            return new ICoreType[1] { new ActivityStreams.Contract.Core.Object(serialisedValue)};
        }
        return new ICoreType[0];
    }


    /// <summary>
    /// 
    /// </summary>
    public override void Write(
        Utf8JsonWriter writer,
        ICoreType[] dateTimeValue,
        JsonSerializerOptions options) 
    {

        writer.WriteStringValue(dateTimeValue.ToString());
    }

}
