using System.Globalization;
using System.Text.Json.Serialization;

namespace ActivityStreams.Common.Models;

/// <summary>
/// As per the <a href="https://www.w3.org/TR/activitystreams-core/#dates">ActivityStreams specification</a>:<br/>
/// All properties with date and time values must conform to the "date-time" production in <a href="https://www.w3.org/TR/activitystreams-core/#bib-RFC3339">RFC3339</a> with the one exception that seconds may be omitted. An uppercase "T" character must be used to separate date and time, and an uppercase "Z" character must be used in the absence of a numeric time zone offset.<br/>
/// This is specified using the following <a href="https://www.w3.org/TR/activitystreams-core/#bib-ABNF">ABNF</a> syntax description.The "time-hour", "time-minute", "time-second", "time-secfrac", "time-offset" and "full-date" constructs are as defined in <a href="https://www.w3.org/TR/activitystreams-core/#bib-RFC3339">RFC3339</a>.<br/>
/// <code>
///   as2-partial-time = time-hour ":" time-minute[":" time - second]
///   [time - secfrac]
///   as2-full-time    = as2-partial-time time-offset
///   as2-date-time    = full-date "T" as2-full-time
/// </code>
/// It is important to note that the `time-offset` component does not correlate to time-zones, and while times that include the `time-offset` component work well for timestamps, they cannot be reliably converted to and from local "wall times" without additional information and processing.
/// </summary>
public record DateTimeXsd
{
    /// <summary>
    /// Constructor for <see cref="DateTimeXsd"/>
    /// </summary>
    /// <param name="rawString">DateTime value represented as a <c>string</c> in <c>xsd:dateTime</c> format</param>
    [JsonConstructor]
    public DateTimeXsd(string rawString)
    {
        if (!DateTimeOffset.TryParse(rawString, null, DateTimeStyles.RoundtripKind, out DateTimeOffset dt))
        {
            throw new ArgumentException($"{nameof(rawString)} is not a recognised XSD DateTime");
        }
        RawString = rawString;
        DateTime = dt;
    }

    /// <inheritdoc cref="DateTimeOffset" />
    public DateTimeOffset DateTime { get; set; }

    /// <summary>
    /// DateTime value represented as a <c>string</c> in <c>xsd:dateTime</c> format
    /// </summary>
    private string RawString { get; init; } = null!;

    /// <summary>
    /// <inheritdoc />
    /// This date string is represented in <c>xsd:dateTime</c> format, 
    /// wherein the original time zone information (if any) has been retained.
    /// </summary>
    public override string ToString() => RawString;
}
