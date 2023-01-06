using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
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
        if (JsonElement.TryParseValue(ref reader, out JsonElement? jElement) && jElement != null)
        {
            if (jElement.Value.ValueKind == JsonValueKind.Object)
            {
                var newObject = Activator.CreateInstance(typeToConvert); // TODO actually calculate instance type based on data, don't trust the one passed in

                var valuesToDeserialiseFrom = jElement.Value.EnumerateObject().ToDictionary(x => x.Name, x => x.Value);

                foreach (var p in typeToConvert.GetProperties())
                {
                    var camelCaseName = StringHelper.ToCamelCase(p.Name);
                    if (camelCaseName == "context") camelCaseName = "@context"; // TODO HACK

                    if (valuesToDeserialiseFrom.ContainsKey(camelCaseName))
                    {
                        var rawValue = valuesToDeserialiseFrom[camelCaseName]; // from this we can tell the type is "Invite"

                        if (rawValue.ValueKind == JsonValueKind.Object)
                        {
                            if (rawValue.TryGetProperty("type", out JsonElement typeElement))
                            {
                                var typeName = typeElement.GetString(); // e.g. "Invite"
                                if (Enum.TryParse(typeName, out ObjectType objectType))
                                {
                                    var modelType = objectType.ToType();
                                    var typedValue = rawValue.Deserialize(modelType, options);

                                    AddSingleOrArray(p, newObject, typedValue);
                                }
                            }
                        }
                        else if (rawValue.ValueKind == JsonValueKind.String)
                        {
                            string? ss = rawValue.GetString();

                            if (!string.IsNullOrEmpty(ss))
                            {
                                if (p.PropertyType.IsAssignableFrom(typeof(ObjectType[])) && Enum.TryParse(ss, out ObjectType objectType))
                                {
                                    p.SetValue(newObject, new[] { objectType });
                                }
                                else if (p.PropertyType.IsAssignableFrom(typeof(String[])))
                                {
                                    p.SetValue(newObject, new[] { ss });
                                }
                                else if (p.PropertyType.IsAssignableFrom(typeof(Uri)))
                                {
                                    p.SetValue(newObject, new Uri(ss)); // TODO validate/tryparse uri safely
                                }
                                else if (p.PropertyType.IsAssignableFrom(typeof(string)))
                                {
                                    p.SetValue(newObject, ss); // TODO validate/tryparse uri safely
                                }
                                else if (typeof(DateTime?).IsAssignableFrom(p.PropertyType) &&
                                            DateTime.TryParse(ss, out DateTime dateTimeValue))
                                {
                                    p.SetValue(newObject, dateTimeValue);
                                }
                                else
                                {
                                    var mappedString = MapString(ss);

                                    AddSingleOrArray(p, newObject, mappedString);
                                }
                            }
                        }
                    }
                }
                return newObject as ICoreType;
            }
        }


        var serializedValue = reader.GetString();
        if (string.IsNullOrEmpty(serializedValue))
        {
            return null;
        }

        try
        {
            return MapString(serializedValue);
        }
        catch (Exception e) 
        {
            throw new SerializationException($"Unable to serialize to {nameof(ICoreType)}", e);
        }

        throw new SerializationException($"Unable to serialize to {nameof(ICoreType)}");
    }

    private ICoreType? MapString(string? stringValue)
    {
        if (string.IsNullOrEmpty(stringValue))
        {
            return null;
        }

        if (Uri.TryCreate(stringValue, UriCreationOptions, out Uri? result))
        {
            // Uri-only indicates 'Link' type
            return new Link { Href = result };
        }

        return new Core.Object { Name = new string[] { stringValue } };
    }

    private void AddSingleOrArray(PropertyInfo p, object? newObject, object? typedValue)
    {
        
        if (typeof(ILink[]).IsAssignableFrom(p.PropertyType) && typedValue is ILink linkValue)
        {
            p.SetValue(newObject, new ILink[] { linkValue });
        }
        else if (typeof(ICoreType[]).IsAssignableFrom(p.PropertyType) && typedValue is ICoreType typedTypeValue)
        {
            p.SetValue(newObject, new ICoreType[] { typedTypeValue });
        }
        else
        {
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
        //writer.WriteStringValue(dateTimeValue.Value.ToString());
    }

}
