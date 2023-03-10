namespace ActivityStreams.Common.Interfaces;

/// <summary>
/// A string, which may be expressed using either a single <c>string</c> value 
/// (<see cref="String"/>) or using multiple language-tagged values 
/// (<see cref="Map"/>). Only one of <c>String</c> or <c>Map</c>
/// should be provided, and if both are present <c>String</c> will take precedence.<br/>
/// The <see cref="MediaType"/> property can be used to indicate a 
/// specific content type (if any).<br/>
/// <a href="https://www.w3.org/TR/rdf-schema/#ch_langstring">RdfLangString</a>
/// </summary>
public interface IRdfLangString
{
    /// <summary>
    /// A simple <c>string</c>, with or without encoding. If the string is encoded the encoding
    /// type will be specified in <see cref="MediaType"/>.
    /// </summary>
    string? String { get; init; }

    /// <summary>
    /// MIME Media Type. If set, specifies how <see cref="String"/> or 
    /// <see cref="Map"/> are encoded.
    /// </summary>
    /// <example>"text/html"</example>
    string? MediaType { get; init; }

    /// <summary>
    /// A <c>string</c> represented as multiple language-tagged values
    /// </summary>
    IDictionary<string, string?>? Map { get; init; }
}
