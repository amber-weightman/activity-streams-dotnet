using System.Collections;
using System.Runtime.Serialization;

namespace ActivityStreams.Contract.Common;

/// <summary>
/// A string, which may be expressed using either a single <c>string</c> value 
/// (<see cref="IRdfLangString.String"/>) or using multiple language-tagged values 
/// (<see cref="IRdfLangString.Map"/>). Only one of <c>String</c> or <c>Map</c>
/// should be provided, and if both are present <c>String</c> will take precedence.<br/>
/// The <see cref="IRdfLangString.MediaType"/> property can be used to indicate a 
/// specific content type (if any).<br/>
/// <a href="https://www.w3.org/TR/rdf-schema/#ch_langstring">RdfLangString</a>
/// </summary>
public interface IRdfLangString : ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable, IDictionary<string, string>, IReadOnlyCollection<KeyValuePair<string, string>>, IReadOnlyDictionary<string, string>, ICollection, IDictionary, IDeserializationCallback, ISerializable
{
    /// <summary>
    /// A simple <c>string</c>, with or without encoding. If the string is encoded the encoding
    /// type will be specified in <see cref="IRdfLangString.MediaType"/>.
    /// </summary>
    string? String { get; init; }

    /// <summary>
    /// MIME Media Type. If set, specifies how <see cref="IRdfLangString.String"/> or 
    /// <see cref="IRdfLangString.Map"/> are encoded.
    /// </summary>
    string? MediaType { get; init; }

    /// <summary>
    /// A <c>string</c> represented as multiple language-tagged values
    /// </summary>
    Dictionary<string, string>? Map { get; init; }
}
