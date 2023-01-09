using ActivityStreams.Contract.Types;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Contract.Core;

/// <summary>
/// A <c>Link</c> is an indirect, qualified reference to a resource identified by
/// a URL. The fundamental model for links is established by [<a href="https://www.w3.org/TR/activitystreams-vocabulary/#bib-RFC5988">RFC5988</a>]. 
/// Many of the properties defined by the Activity Vocabulary allow values 
/// that are either instances of <c>Object</c> (here implemented as <see cref="IObject"/>) or <c>Link</c>. When a <c>Link</c> is used, it 
/// establishes a qualified relation connecting the subject (the containing 
/// object) to the resource identified by the href. Properties of the <c>Link</c> 
/// are properties of the reference as opposed to properties of the resource.
/// <a href="https://www.w3.org/ns/activitystreams#Link">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Link",
///   "href": "http://example.org/abc",
///   "hreflang": "en",
///   "mediaType": "text/html",
///   "name": "An example link"
/// }
/// </code>
/// </example>
public interface ILink : ICoreType
{
    /// <summary>
    /// The target resource pointed to by a <c>Link</c> (here implemented as <see cref="ILink"/>).
    /// <a href="https://www.w3.org/ns/activitystreams#href">See w3.org for further details.</a>
    /// </summary>
    Uri? Href { get; }

    /// <summary>
    /// A link relation associated with a <c>Link</c>.The value must conform to both 
    /// the[HTML5] and[RFC5988] "link relation" definitions.<br/>
    /// In the[HTML5], any string not containing the "space" U+0020, "tab" (U+0009), "LF" (U+000A), 
    /// "FF" (U+000C), "CR" (U+000D) or "," (U+002C) characters can be used as a valid link relation.
    /// <a href="https://www.w3.org/ns/activitystreams#rel">See w3.org for further details.</a>
    /// </summary>
    string[]? Rel { get; } // TODO [RFC5988] or [HTML5] Link Relation

    /// <summary>
    /// Hints as to the language used by the target resource. Value must be a 
    /// <a href="https://www.w3.org/TR/activitystreams-vocabulary/#bib-BCP47">BCP47</a> Language-Tag.
    /// <a href="https://www.w3.org/ns/activitystreams#hreflang">See w3.org for further details.</a>
    /// </summary>
    string? HrefLang { get; } // TODO [BCP47] Language Tag

    /// <summary>
    /// On a <c>Link</c> (here implemented as <see cref="ILink"/>), specifies a hint as to the rendering height in device-independent 
    /// pixels of the linked resource.
    /// <a href="https://www.w3.org/ns/activitystreams#height">See w3.org for further details.</a>
    /// </summary>
    [Range(0, int.MaxValue)]
    int? Height { get; }

    /// <summary>
    /// On a <c>Link</c> (here implemented as <see cref="ILink"/>), specifies a hint as to the rendering width in device-independent pixels of the linked resource.
    /// <a href="https://www.w3.org/ns/activitystreams#width">See w3.org for further details.</a>
    /// </summary>
    [Range(0, int.MaxValue)]
    int? Width { get; }
}
