namespace ActivityStreams.Utilities.Helpers;

/// <summary>
/// <see cref="string"/> utilities and helpers
/// </summary>
internal static class StringHelper
{
    /// <summary>
    /// Convert a <c>string</c> to <c>camelCase</c>
    /// </summary>
    public static string ToCamelCase(this string str) =>
        char.ToLowerInvariant(str[0]) + str[1..];
}
