using System.Xml;

namespace ActivityStreams.Models.Utilities.Helpers;

/// <summary>
/// <see cref="TimeSpan"/> utilities and helpers
/// </summary>
public static class TimeSpanHelper
{
    /// <summary>
    /// Convert <c>xsd:duration</c> string to <see cref="TimeSpan" />
    /// </summary>
    public static TimeSpan ToTimeSpan(string str)
    {
        return XmlConvert.ToTimeSpan(str);
    }

    /// <summary>
    /// Convert <see cref="TimeSpan" /> to <c>xsd:duration</c> string
    /// </summary>
    public static string ToString(TimeSpan timeSpan)
    {
        return XmlConvert.ToString(timeSpan);
    }
}
