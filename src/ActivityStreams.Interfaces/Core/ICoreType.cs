using ActivityStreams.Contract.Types;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ActivityStreams.Contract.Core;

/// <summary>
/// A <c>CoreType</c> is an abstract base type for all ActivityStreams types.
/// </summary>
public interface ICoreType
{
    /// <summary>
    /// Provides the globally unique identifier for an <c>Object</c> (here implemented as <see cref="IObject"/>) or <c>Link</c> (here implemented as <see cref="ILink"/>).
    /// </summary>
    /// <example>"http://example.org/foo"</example>
    Uri? Id { get; }

    /// <summary>
    /// Identifies the context within which the object exists or an 
    /// activity was performed.<br/>
    /// The notion of "context" used is intentionally vague.The intended
    /// function is to serve as a means of grouping objects and 
    /// activities that share a common originating context or purpose.
    /// An example could be all activities relating to a common project 
    /// or event.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#context">See w3.org for further details.</a>
    /// </summary>
    /// <example>"https://www.w3.org/ns/activitystreams"</example>
    [JsonPropertyName("@context")]
    ICoreType[]? Context { get; }

    /// <summary>
    /// <a href="https://www.w3.org/TR/activitystreams-vocabulary/#properties">W3.org</a> 
    /// documentation is unclear as to whether this is a URI or not.
    /// </summary>
    abstract ObjectType[]? Type { get; }

    /// <summary>
    /// Identifies one or more entities to which this object is attributed. 
    /// The attributed entities might not be Actors. For instance, an 
    /// object might be attributed to the completion of another activity.
    /// <a href="https://www.w3.org/ns/activitystreams#attributedTo">See w3.org for further details.</a>
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// </summary>
    ICoreType[]? AttributedTo { get; }

    /// <summary>
    /// Identifies an entity that provides a preview of this object.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#preview">See w3.org for further details.</a>
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// </summary>
    ICoreType[]? Preview { get; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. 
    /// The name may be expressed using multiple language-tagged values.
    /// <a href="https://www.w3.org/ns/activitystreams#name">See w3.org for further details.</a>
    /// </summary>
    string[]? Name { get; } // TODO serialise xsd:string | rdf:langString

    /// <summary>
    /// When used on a Link, identifies the MIME media type of the referenced resource.<br/>
    /// When used on an Object, identifies the MIME media type of the value of the content 
    /// property.If not specified, the content property is assumed to contain text/html content.
    /// <a href="https://www.w3.org/ns/activitystreams#mediaType">See w3.org for further details.</a>
    /// </summary>
    /// <example>"text/html"</example>
    string? MediaType { get; } // TODO MIME Media Type
}
