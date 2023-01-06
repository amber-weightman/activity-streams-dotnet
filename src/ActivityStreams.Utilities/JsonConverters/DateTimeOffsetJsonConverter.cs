using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Utilities.JsonConverters;

/// <summary>
/// Sample implementation from <a href="https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/converters-how-to?pivots=dotnet-6-0">Microsoft</a>
/// </summary>
public class DateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public override DateTimeOffset Read(
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
            DateTimeOffset.ParseExact(reader.GetString()!,
                "MM/dd/yyyy", CultureInfo.InvariantCulture);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public override void Write(
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        Utf8JsonWriter writer,
        DateTimeOffset dateTimeValue,
        JsonSerializerOptions options) =>
            writer.WriteStringValue(dateTimeValue.ToString(
                "MM/dd/yyyy", CultureInfo.InvariantCulture));
}
