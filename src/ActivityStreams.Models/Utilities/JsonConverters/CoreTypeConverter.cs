using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using ActivityStreams.Models.Core;
using ActivityStreams.Models.Utilities.Extensions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Utilities.JsonConverters;

/// <summary>
/// Converters for serializing to/from <c><see cref="ICoreType"/></c> 
/// </summary>
public class CoreTypeConverter : JsonConverter<ICoreType>
{
    private static UriCreationOptions UriCreationOptions = new();

    /// <summary>
    /// TODO (CLEANUP THIS WHOLE FILE)
    /// </summary>
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(ICoreType).IsAssignableFrom(typeToConvert);
    }

    /// <summary>
    /// Convert a serialized <c>string</c> to the <c>ICoreType</c> it represents
    /// </summary>
    public override ICoreType? Read(ref Utf8JsonReader reader, Type _, JsonSerializerOptions options)
    {
        try
        {
            if (JsonElement.TryParseValue(ref reader, out JsonElement? jElement) && jElement != null &&
                jElement.Value.ValueKind == JsonValueKind.Object)
            {
                var baseObjectType = GetObjectType(jElement.Value);
                if (baseObjectType == null)
                {
                    throw new ArgumentException("Unexpected Type");
                }

                var newObject = Activator.CreateInstance(baseObjectType);

                var valuesToDeserialiseFrom = jElement.Value.EnumerateObject().ToDictionary(x => x.Name, x => x.Value);
                var propertiesToPopulateInto = baseObjectType.GetProperties();

                foreach (var property in propertiesToPopulateInto)
                {
                    var camelCasePropertyName = GetCamelCasePropertyName(property);
                    if (!valuesToDeserialiseFrom.ContainsKey(camelCasePropertyName))
                    {
                        continue;
                    }

                    var serializedProperty = valuesToDeserialiseFrom[camelCasePropertyName];

                    switch (serializedProperty.ValueKind)
                    {
                        case JsonValueKind.Object:
                            {
                                var objectType = GetObjectType(serializedProperty);
                                if (objectType != null)
                                {
                                    var typedValue = serializedProperty.Deserialize(objectType, options);
                                    AddCoreType(property, newObject, typedValue);
                                }
                                break;
                            }
                        
                        case JsonValueKind.Array:
                            {
                                if (typeof(ILink[]).IsAssignableFrom(property.PropertyType))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<ILink[]>(serializedProperty, options));
                                    break;
                                }
                                else if (typeof(IObject[]).IsAssignableFrom(property.PropertyType))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<IObject[]>(serializedProperty, options));
                                    break;
                                }
                                else if (typeof(ICoreType[]).IsAssignableFrom(property.PropertyType))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<ICoreType[]>(serializedProperty, options));
                                    break;
                                }
                                break;
                            }

                        case JsonValueKind.String:
                            {
                                if (property.PropertyType.IsAssignableFrom(typeof(Uri)))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<Uri>(serializedProperty, options));
                                    break;
                                }
                                else if (property.PropertyType.IsAssignableFrom(typeof(string)))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<string>(serializedProperty, options));
                                    break;
                                }
                                else if (property.PropertyType.IsAssignableFrom(typeof(string[])))
                                {
                                    property.SetValue(newObject, new[] { JsonSerializer.Deserialize<string>(serializedProperty, options) });
                                    break;
                                }
                                else if (typeof(DateTimeXsd).IsAssignableFrom(property.PropertyType))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<DateTimeXsd>(serializedProperty, options));
                                    break;
                                }
                                else if (property.PropertyType.IsAssignableFrom(typeof(ObjectType[])))
                                {
                                    property.SetValue(newObject, new[] { JsonSerializer.Deserialize<ObjectType>(serializedProperty, options) });
                                    break;
                                }
                                else if (typeof(IRdfLangString).IsAssignableFrom(property.PropertyType))
                                {
                                    property.SetValue(newObject, JsonSerializer.Deserialize<RdfLangString>(serializedProperty, options));
                                    break;
                                }

                                string? propertyValueString = serializedProperty.GetString();
                                if (string.IsNullOrEmpty(propertyValueString))
                                {
                                    break;
                                }

                                if (Uri.TryCreate(propertyValueString, UriCreationOptions, out Uri? result))
                                {
                                    // Uri-only indicates 'Link' type
                                    AddCoreType(property, newObject, new Link { Href = result });
                                    break;
                                }
                                else
                                {
                                    throw new SerializationException($"Unable to deserialize");
                                }
                            }
                    }
                }
                return newObject as ICoreType;
            }
        }
        catch (Exception ex)
        {
            throw new SerializationException($"Unable to deserialize to {nameof(ICoreType)}", ex);
        }

        throw new SerializationException($"Unable to deserialize to {nameof(ICoreType)}");
    }

    private static string GetCamelCasePropertyName(PropertyInfo property)
    {
        var jsonPropertyName = property.GetCustomAttribute<JsonPropertyNameAttribute>();
        if (jsonPropertyName != null)
        {
            return jsonPropertyName.Name;
        }
        return StringHelper.ToCamelCase(property.Name);
    }

    private static Type? GetObjectType(JsonElement jsonElement)
    {
        if (jsonElement.TryGetProperty("type", out JsonElement typeElement) && 
            Enum.TryParse(typeElement.GetString(), out ObjectType objectType))
        {
            return objectType.ToType();
        }
        return null;
    }

    // TODO what if there are multiple items in the array - is that working?
    private static void AddCoreType(PropertyInfo p, object? newObject, object? typedValue)
    {
        if (typeof(ILink[]).IsAssignableFrom(p.PropertyType))
        {
            if (typedValue is ILink linkValue)
            {
                p.SetValue(newObject, new ILink[] { linkValue });
            }
            else if (typedValue is ILink[] linkArrayValue)
            {
                p.SetValue(newObject, linkArrayValue);
            }
        }
        else if (typeof(IObject[]).IsAssignableFrom(p.PropertyType))
        {
            if (typedValue is IObject typedObjectValue)
            {
                p.SetValue(newObject, new IObject[] { typedObjectValue });
            }
            else if (typedValue is IObject[] typedObjectArrayValue)
            {
                p.SetValue(newObject, typedObjectArrayValue);
            }
        }
        else if (typeof(ICoreType[]).IsAssignableFrom(p.PropertyType))
        {
            if (typedValue is ICoreType typedTypeValue)
            {
                p.SetValue(newObject, new ICoreType[] { typedTypeValue });
            }
            else if (typedValue is ICoreType[] typedTypeArrayValue)
            {
                p.SetValue(newObject, typedTypeArrayValue);
            }
        }
        else
        {
            // Target is a single object (presumed to be of ICoreType), not an array
            p.SetValue(newObject, typedValue);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public override void Write(
        Utf8JsonWriter writer,
        ICoreType? dateTimeValue,
        JsonSerializerOptions options) 
    {

        throw new NotImplementedException();
    }

}
