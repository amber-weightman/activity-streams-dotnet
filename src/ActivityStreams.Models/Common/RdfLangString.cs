using ActivityStreams.Contract.Common;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace ActivityStreams.Models.Common;

/// <inheritdoc cref="IRdfLangString"/>
public record RdfLangString : IDictionary<string, string>, IReadOnlyDictionary<string, string>, IDictionary, IDeserializationCallback, ISerializable
{
    /// <inheritdoc cref="IRdfLangString.String"/>
    public string? String { get; init; }

    /// <inheritdoc cref="IRdfLangString.MediaType"/>
    public string? MediaType { get; init; }

    /// <inheritdoc cref="IRdfLangString.Map"/>
    public Dictionary<string, string>? Map { get; init; }

    /// <inheritdoc />
    public string this[string key] { get => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); set => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); }

    /// <inheritdoc />
    public object? this[object key] { get => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); set => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); }

    /// <inheritdoc />
    public int Count => !string.IsNullOrEmpty(String) ? 1 : Map == null ? 0 : Map.Count;

    /// <inheritdoc />
    public bool IsReadOnly => true; // As a record, RdfLangString should always be ReadOnly

    /// <inheritdoc />
    public ICollection<string> Keys => Map == null ? global::System.Array.Empty<string>() : Map.Keys;

    /// <inheritdoc />
    public bool IsSynchronized => false;

    /// <inheritdoc />
    public object SyncRoot => throw new NotSupportedException();

    /// <inheritdoc />
    public bool IsFixedSize => true;

    ICollection<string> IDictionary<string, string>.Values => Map == null ? global::System.Array.Empty<string>() : Map.Values;

    IEnumerable<string> IReadOnlyDictionary<string, string>.Values => Map == null ? global::System.Array.Empty<string>() : Map.Values;

    ICollection IDictionary.Values => Map == null ? global::System.Array.Empty<string>() : Map.Values;

    IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => Map == null ? global::System.Array.Empty<string>() : Map.Keys;

    ICollection IDictionary.Keys => Map == null ? global::System.Array.Empty<string>() : Map.Keys;

    /// <inheritdoc />
    public void Add(KeyValuePair<string, string> item) => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");

    /// <inheritdoc />
    public void Add(string key, string value) => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");

    /// <inheritdoc />
    public void Add(object key, object? value) => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");

    /// <inheritdoc />
    public void Clear() => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");

    /// <inheritdoc />
    public bool Contains(KeyValuePair<string, string> item)
    {
        return Map != null && Map[item.Key] == item.Value;
    }

    /// <inheritdoc />
    public bool Contains(object key)
    {
        return Map != null && key != null && key is string && Map.ContainsKey((string)key);
    }

    /// <inheritdoc />
    public bool ContainsKey(string key)
    {
        return Map != null && Map.ContainsKey(key);
    }

    /// <inheritdoc />
    public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
    {
        if (Map == null) throw new NotSupportedException();
        var mapArray = Map.ToArray();
        mapArray.CopyTo(array, arrayIndex);
    }

    /// <inheritdoc />
    public void CopyTo(Array array, int index)
    {
        if (Map is not null)
        {
            var mapArray = Map.ToArray();
            mapArray.CopyTo(array, index);
        }
        else
        {
            array.SetValue(String, index);
        }    
    }

    /// <inheritdoc />
    public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
    {
        if (Map is null) throw new NotSupportedException();
        return Map.GetEnumerator();
    }

    /// <inheritdoc />
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        if (Map is not null)
        {
            Map.GetObjectData(info, context);
        }
    }

    /// <inheritdoc />
    public void OnDeserialization(object? sender)
    {
        if (Map is not null)
        {
            Map.OnDeserialization(sender);
        }
    }

    /// <inheritdoc />
    public bool Remove(KeyValuePair<string, string> item)
    {
        if (Map is null) throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");
        return Map.Remove(item.Key);
    }

    /// <inheritdoc />
    public bool Remove(string key)
    {
        if (Map is null) throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");
        return Map.Remove(key);
    }

    /// <inheritdoc />
    public void Remove(object key)
    {
        if (Map is null) throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");
        Map.Remove((string)key);
    }

    /// <inheritdoc />
    public bool TryGetValue(string key, [MaybeNullWhen(false)] out string value)
    {
        if (Map is null)
        {
            value = null;
            return false;
        }

        return Map.TryGetValue(key, out value);
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        if (Map is null) throw new NotSupportedException();
        return Map.GetEnumerator();
    }

    /// <inheritdoc />
    IDictionaryEnumerator IDictionary.GetEnumerator()
    {
        if (Map is null) throw new NotSupportedException();
        return Map.GetEnumerator();
    }

    /// <inheritdoc />
    public override string? ToString() => !string.IsNullOrEmpty(String) ? String : Map == null ? base.ToString() : Map.ToString();
}
