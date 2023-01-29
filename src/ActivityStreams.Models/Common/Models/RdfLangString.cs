using ActivityStreams.Common.Interfaces;

namespace ActivityStreams.Common.Models;

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

    /// <summary>
    /// Get a collection containing all keys (if any)
    /// </summary>
    /// <returns></returns>
    public ICollection<string> GetKeys()
    {
        if (Map is null)
        {
            return Array.Empty<string>();
        }
        return Map.Keys;
    }

    /// <summary>
    /// Get a collection containing all values
    /// </summary>
    public ICollection<string> GetValues()
    {
        if (Map is null)
        {
            if (!string.IsNullOrEmpty(String))
            {
                return new string[] { String };
            }
            return Array.Empty<string>();
        }

        return Map.Values.Where(v => v is not null).Select(v => v!).ToArray();
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
