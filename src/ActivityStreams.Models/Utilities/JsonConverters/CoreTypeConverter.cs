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
    public override ICoreType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            if (JsonElement.TryParseValue(ref reader, out JsonElement? jElement))
            {
                var baseObjectType = GetObjectType(jElement!.Value);
                if (baseObjectType == null)
                {
                    throw new ArgumentException("Unexpected Type");
                }

                var newObject = Activator.CreateInstance(baseObjectType);

                var valuesToDeserialiseFrom = jElement.Value.EnumerateObject().ToDictionary(x => x.Name, x => x.Value);
                var propertiesToPopulateInto = baseObjectType.GetProperties();

                foreach (var property in propertiesToPopulateInto)
                {
                    var camelCasePropertyName = property.GetJsonPropertyName();
                    if (!valuesToDeserialiseFrom.ContainsKey(camelCasePropertyName))
                    {
                        continue;
                    }

                    var serializedProperty = valuesToDeserialiseFrom[camelCasePropertyName];

                    switch (serializedProperty.ValueKind)
                    {
                        case JsonValueKind.Object:
                            {
                                SetObjectProperty(newObject, property, serializedProperty, options);
                                break;
                            }
                        
                        case JsonValueKind.Array:
                            {
                                SetArrayProperty(newObject, property, serializedProperty, options);
                                break;
                            }

                        case JsonValueKind.String:
                            {
                                SetProperty(newObject, property, serializedProperty, options);
                                break;
                            }
                        case JsonValueKind.Number:
                            {
                                SetNumericProperty(newObject, property, serializedProperty, options);
                                break;
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

    private static void SetObjectProperty(object? newObject, PropertyInfo newObjectProperty, JsonElement serializedProperty, JsonSerializerOptions options)
    {
        var objectType = GetObjectType(serializedProperty);
        if (objectType != null)
        {
            var typedValue = serializedProperty.Deserialize(objectType, options);
            AddCoreType(newObjectProperty, newObject, typedValue);
        }
    }

    private static void SetArrayProperty(object? newObject, PropertyInfo newObjectProperty, JsonElement serializedProperty, JsonSerializerOptions options)
    {
        if (typeof(ILink[]).IsAssignableFrom(newObjectProperty.PropertyType))
        {
            newObjectProperty.SetValue(newObject, HandleArray<ILink>(serializedProperty, options));
        }
        else if (typeof(IObject[]).IsAssignableFrom(newObjectProperty.PropertyType))
        {
            newObjectProperty.SetValue(newObject, HandleArray<IObject>(serializedProperty, options));
        }
        else if (typeof(ICoreType[]).IsAssignableFrom(newObjectProperty.PropertyType))
        {
            newObjectProperty.SetValue(newObject, HandleArray<ICoreType>(serializedProperty, options));
        }
    }

    private static T[]? HandleArray<T>(JsonElement jElement, JsonSerializerOptions options) where T : ICoreType
    {
        if (jElement.ValueKind == JsonValueKind.Array)
        {
            T[] arrayItems = jElement.EnumerateArray().Select(e =>
            {
                Type? baseObjectTypee = GetObjectType(e);
                var deser = JsonSerializer.Deserialize(e, baseObjectTypee!, options);
                return (T)deser!;
            }).ToArray();
            return arrayItems;
        }
        return null;
    }

    private static void SetProperty(object? newObject, PropertyInfo newObjectProperty, JsonElement serializedProperty, JsonSerializerOptions options)
    {
        if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(Uri)))
        {
            newObjectProperty.SetValue(newObject, JsonSerializer.Deserialize<Uri>(serializedProperty, options));
            return;
        }
        else if (newObjectProperty.PropertyType == typeof(string))
        {
            newObjectProperty.SetValue(newObject, JsonSerializer.Deserialize<string>(serializedProperty, options));
            return;
        }
        else if (newObjectProperty.PropertyType == typeof(string[]))
        {
            newObjectProperty.SetValue(newObject, new[] { JsonSerializer.Deserialize<string>(serializedProperty, options) });
            return;
        }
        else if (newObjectProperty.PropertyType == typeof(object[]))
        {
            newObjectProperty.SetValue(newObject, new[] { JsonSerializer.Deserialize<object>(serializedProperty, options) });
            return;
        }
        else if (newObjectProperty.PropertyType == typeof(DateTimeXsd))
        {
            newObjectProperty.SetValue(newObject, JsonSerializer.Deserialize<DateTimeXsd>(serializedProperty, options));
            return;
        }
        else if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(ObjectType[])))
        {
            newObjectProperty.SetValue(newObject, new[] { JsonSerializer.Deserialize<ObjectType>(serializedProperty, options) });
            return;
        }
        else if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(IAnyUri[])))
        {
            newObjectProperty.SetValue(newObject, new [] { JsonSerializer.Deserialize<IAnyUri>(serializedProperty, options) });
            return;
        }
        else if (typeof(IRdfLangString).IsAssignableFrom(newObjectProperty.PropertyType))
        {
            newObjectProperty.SetValue(newObject, JsonSerializer.Deserialize<RdfLangString>(serializedProperty, options));
            return;
        }

        string? propertyValueString = serializedProperty.GetString();
        if (string.IsNullOrWhiteSpace(propertyValueString) ||
            propertyValueString.Equals("{}") || propertyValueString.Equals("{ }"))
        {
            return;
        }

        if (Uri.TryCreate(propertyValueString, UriCreationOptions, out Uri? result))
        {
            if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(ILink)) || newObjectProperty.PropertyType.IsAssignableFrom(typeof(ILink[])))
            {
                // Uri-only usually indicates 'Link' type but not always (at least according to explicit documentation - see Relationship_0 test/s)
                AddCoreType(newObjectProperty, newObject, new Link { Href = result });
            }
            else if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(IObject)) || newObjectProperty.PropertyType.IsAssignableFrom(typeof(IObject[])))
            {
                AddCoreType(newObjectProperty, newObject, new Core.Object { Type = new[] { new AnyUri(result) } });
            }
            return;
        }

        // TODO if this fails, it silently fails (same with the other mappings)
    }

    private static void SetNumericProperty(object? newObject, PropertyInfo newObjectProperty, JsonElement serializedProperty, JsonSerializerOptions options)
    {
        if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(int)))
        {
            newObjectProperty.SetValue(newObject, JsonSerializer.Deserialize<int>(serializedProperty, options));
            return;
        }
        else if (newObjectProperty.PropertyType.IsAssignableFrom(typeof(float)))
        {
            newObjectProperty.SetValue(newObject, JsonSerializer.Deserialize<float>(serializedProperty, options));
            return;
        }
    }

    private static Type? GetObjectType(JsonElement jsonElement)
    {
        if (jsonElement.TryGetProperty("type", out JsonElement typeElement) &&
            Enum.TryParse(typeElement.GetString(), out ObjectType objectType))
        {
            return objectType.ToType();
        }

        // TODO is it always OK to fallback to Object where the type is not in our enum?
        return typeof(Core.Object);
    }

    private static bool TryAddType<T>(PropertyInfo p, object? newObject, object value)
    {
        if (typeof(T[]).IsAssignableFrom(p.PropertyType))
        {
            if (value is T typedValue)
            {
                var array = Array.CreateInstance(typeof(T), 1);
                array.SetValue(typedValue, 0);
                p.SetValue(newObject, array);
                return true;
            }
            else if (value is T[] typedArrayValue)
            {
                p.SetValue(newObject, typedArrayValue);
                return true;
            }
        }
        
        return false;
    }

    private static void AddCoreType(PropertyInfo p, object? newObject, object? typedValue)
    {
        if (typedValue == null)
        {
            return;
        }

        if (TryAddType<ILink>(p, newObject, typedValue) ||
            TryAddType<IObject>(p, newObject, typedValue) ||
            TryAddType<ICoreType>(p, newObject, typedValue))
        {
            return;
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
