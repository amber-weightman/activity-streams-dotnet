using ActivityStreams.Utilities.Helpers;
using System.Reflection;
using System.Text.Json.Serialization;

namespace ActivityStreams.Extensions;

/// <summary>
/// <see cref="PropertyInfo"/> extensions
/// </summary>
internal static class PropertyInfoExtensions
{
    /// <summary>
    /// Get the <c>camelCase</c> JSON property name for a <see cref="PropertyInfo"/> object
    /// </summary>
    public static string GetJsonPropertyName(this PropertyInfo property)
    {
        var jsonPropertyName = property.GetCustomAttribute<JsonPropertyNameAttribute>();
        if (jsonPropertyName != null)
        {
            return jsonPropertyName.Name;
        }
        return StringHelper.ToCamelCase(property.Name);
    }
}
