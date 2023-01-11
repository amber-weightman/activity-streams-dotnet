using ActivityStreams.Contract.Common;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace ActivityStreams.Models.Common;

/// <inheritdoc cref="IRdfLangString"/>
public sealed record RdfLangString : IRdfLangString
{
    /// <summary>
    /// Constructor for <see cref="RdfLangString"/>
    /// </summary>
    public RdfLangString()
    {
    }

    /// <summary>
    /// Constructor for <see cref="RdfLangString"/>
    /// </summary>
    public RdfLangString(string value)
    {
        String = value;
    }

    /// <inheritdoc cref="IRdfLangString.String"/>
    public string? String { get; init; }

    /// <inheritdoc cref="IRdfLangString.MediaType"/>
    public string? MediaType { get; init; }

    /// <inheritdoc cref="IRdfLangString.Map"/>
    public IDictionary<string, string?>? Map { get; init; }

    /// <inheritdoc />
    public string this[string key] { get => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); set => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); }

    /// <inheritdoc />
    public object? this[object key] { get => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); set => throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only"); }

    /// <inheritdoc />
    public int Count
    {
        get
        {
            if (!string.IsNullOrWhiteSpace(String))
            {
                return 1;
            }
            if (Map is null)
            {
                return 0;
            }
            return Map.Count;
        }
    }

    /// <inheritdoc />
    public bool IsReadOnly => true; // As a record, RdfLangString should always be ReadOnly

    /// <inheritdoc />
    public bool IsSynchronized => false;

    /// <inheritdoc />
    public object SyncRoot => throw new NotSupportedException();

    /// <inheritdoc />
    public bool IsFixedSize => true;

    /// <inheritdoc />
    public ICollection<string> Keys
    {
        get
        {
            if (Map is null)
            {
                return Array.Empty<string>();
            }
            return Map.Keys;
        }
    }

    /// <inheritdoc />
    IEnumerable<string> IReadOnlyDictionary<string, string>.Keys
    {
        get
        {
            if (Map is null)
            {
                return Array.Empty<string>();
            }
            return Map.Keys;
        }
    }

    /// <inheritdoc />
    ICollection IDictionary.Keys
    {
        get
        {
            if (Map is null)
            {
                return Array.Empty<string>();
            }
            return (ICollection)Map.Keys;
        }
    }

    /// <inheritdoc />
    ICollection IDictionary.Values
    {
        get
        {
            if (Map is null)
            {
                return Array.Empty<string>();
            }
            return (ICollection)Map.Values;
        }
    }

    /// <inheritdoc />
    public ICollection<string> Values
    {
        get
        {
            if (Map is null)
            {
                return Array.Empty<string>();
            }
            var result = new List<string>();
            foreach (var value in Map.Values)
            {
                if (value is not null)
                {
                    result.Add(value);
                }
            }
            return result;
        }
    }

    /// <inheritdoc />
    IEnumerable<string> IReadOnlyDictionary<string, string>.Values
    {
        get
        {
            if (Map is null)
            {
                return Array.Empty<string>();
            }
            var result = new List<string>();
            foreach (var value in Map.Values)
            {
                if (value is not null)
                {
                    result.Add(value);
                }
            }
            return result;
        }
    }

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
        if (Map is null)
        {
            return false;
        }
        return Map[item.Key] == item.Value;
    }

    /// <inheritdoc />
    public bool Contains(object key)
    {
        if (Map is null || key is null || key is not string)
        {
            return false;
        }
        return Map.ContainsKey((string)key);
    }

    /// <inheritdoc />
    public bool ContainsKey(string key)
    {
        if (Map is null || key is null)
        {
            return false;
        }
        return Map.ContainsKey(key);
    }

    /// <inheritdoc />
    public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
    {
        if (Map is null)
        {
            throw new NotSupportedException();
        }
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
        return ((Dictionary<string, string?>?)Map!).GetEnumerator();
    }

    /// <inheritdoc />
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        if (Map is not null)
        {
            ((Dictionary<string, string?>?)Map!).GetObjectData(info, context);
        }
    }

    /// <inheritdoc />
    public void OnDeserialization(object? sender)
    {
        if (Map is not null)
        {
            ((Dictionary<string, string?>?)Map!).OnDeserialization(sender);
        }
    }

    /// <inheritdoc />
    public bool Remove(KeyValuePair<string, string> item)
    {
        if (Map is null)
        {
            throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");
        }
        return Map.Remove(item.Key);
    }

    /// <inheritdoc />
    public bool Remove(string key)
    {
        if (Map is null)
        {
            throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");
        }
        return Map.Remove(key);
    }

    /// <inheritdoc />
    public void Remove(object key)
    {
        if (Map is null)
        {
            throw new NotSupportedException($"{nameof(RdfLangString)} is Read Only");
        }
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
        if (Map is null)
        {
            throw new NotSupportedException();
        }
        return Map.GetEnumerator();
    }

    /// <inheritdoc />
    IDictionaryEnumerator IDictionary.GetEnumerator()
    {
        if (Map is null)
        {
            throw new NotSupportedException();
        }
        return (IDictionaryEnumerator)Map.GetEnumerator();
    }

    /// <inheritdoc />
    public override string? ToString()
    {
        if (!string.IsNullOrWhiteSpace(String))
        {
            return String;
        }
        if (Map is not null)
        {
            return Map.ToString();
        }
        return base.ToString();
    }
}
