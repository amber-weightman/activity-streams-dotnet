using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Types;
using ActivityStreams.Extensions;
using ActivityStreams.Utilities.Helpers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ActivityStreams.Utilities.Converters;

/// <summary>
/// Converters for serializing to/from <c><see cref="ICoreType"/></c> 
/// </summary>
internal class CoreTypeConverter : JsonConverter<ICoreType>
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
            if (!JsonElement.TryParseValue(ref reader, out JsonElement? jElement))
            {
                return null;
            }

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
        catch (Exception ex)
        {
            throw new SerializationException($"Unable to deserialize to {nameof(ICoreType)}", ex);
        }
    }

    private static void SetObjectProperty(object? newObject, PropertyInfo newObjectProperty, JsonElement serializedProperty, JsonSerializerOptions options)
    {
        var prop = DeserializeJsonProperty(serializedProperty, options);
        if (prop != null)
        {
            AddCoreType(newObjectProperty, newObject, prop);
        }
    }

    private static object? DeserializeJsonProperty(JsonElement jElement, JsonSerializerOptions options)
    {
        var objectType = GetObjectType(jElement);
        if (objectType != null)
        {
            switch (jElement.ValueKind)
            {
                case JsonValueKind.Object:
                    return jElement.Deserialize(objectType, options);
                case JsonValueKind.String:
                    {

                        string? propertyValueString = jElement.GetString();
                        if (JsonConverterHelper.IsEmpty(propertyValueString))
                        {
                            return null;
                        }

                        return DeserializeString(objectType, propertyValueString!);
                    }
            }
        }
        return null;
    }

    private static void SetArrayProperty(object? newObject, PropertyInfo newObjectProperty, JsonElement serializedProperty, JsonSerializerOptions options)
    {
        if (typeof(IStreamsLink[]).IsAssignableFrom(newObjectProperty.PropertyType))
        {
            newObjectProperty.SetValue(newObject, HandleArray<IStreamsLink>(serializedProperty, options));
        }
        else if (typeof(IStreamsObject[]).IsAssignableFrom(newObjectProperty.PropertyType))
        {
            newObjectProperty.SetValue(newObject, HandleArray<IStreamsObject>(serializedProperty, options));
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
            return jElement.EnumerateArray().Select(e => (T)DeserializeJsonProperty(e, options)!).ToArray();
        }
        return Array.Empty<T>();
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
            try
            {
                var dateTime = JsonSerializer.Deserialize<DateTimeXsd>(serializedProperty, options);
                newObjectProperty.SetValue(newObject, new[] { dateTime });
            }
            catch
            {
                newObjectProperty.SetValue(newObject, new[] { JsonSerializer.Deserialize<object>(serializedProperty, options) });
            }
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
        if (JsonConverterHelper.IsEmpty(propertyValueString))
        {
            return;
        }

        var typedValue = DeserializeString(newObjectProperty.PropertyType, propertyValueString!);
        if (typedValue != null)
        {
            AddCoreType(newObjectProperty, newObject, typedValue);
            return;
        }

        // TODO if this fails, it silently fails (same with the other mappings)
    }

    private static object? DeserializeString(Type type, string value)
    {
        // Handle TimeSpans
        if (type.IsAssignableFrom(typeof(TimeSpan)))
        {
            return TimeSpanHelper.ToTimeSpan(value!);
        }

        // Handle URIs
        if (Uri.TryCreate(value, UriCreationOptions, out Uri? result))
        {
            if (typeof(IStreamsLink).IsAssignableFrom(type) || 
                    type.IsAssignableFrom(typeof(IStreamsLink)) ||
                    typeof(IStreamsLink[]).IsAssignableFrom(type) ||
                    type.IsAssignableFrom(typeof(IStreamsLink[]))
                )
            {
                // Uri-only usually indicates 'Link' type but not always (at least according to explicit documentation - see Relationship_0 test/s)
                return new StreamsLink { Href = result } as IStreamsLink;
            }
            else if (typeof(IStreamsObject).IsAssignableFrom(type) || 
                    type.IsAssignableFrom(typeof(IStreamsObject)) ||
                    typeof(IStreamsObject[]).IsAssignableFrom(type) ||
                    type.IsAssignableFrom(typeof(IStreamsObject[]))
                )
            {
                return new StreamsObject { Type = new[] { new AnyUri(result) } } as IStreamsObject;
            }
        }

        return null;
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
        switch (jsonElement.ValueKind)
        {
            case JsonValueKind.Object:
                {
                    if (jsonElement.TryGetProperty("type", out JsonElement typeElement) &&
                                Enum.TryParse(typeElement.GetString(), out ObjectType objectType))
                    {
                        return objectType.ToType();
                    }

                    // TODO is it always OK to fallback to Object where the type is not in our enum?
                    return typeof(StreamsObject);
                }
            case JsonValueKind.String:
                {
                    return typeof(StreamsLink);
                }
            default:
                return typeof(StreamsObject);
        }
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

        if (TryAddType<IStreamsLink>(p, newObject, typedValue) ||
            TryAddType<IStreamsObject>(p, newObject, typedValue) ||
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
