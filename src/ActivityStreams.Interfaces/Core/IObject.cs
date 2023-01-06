using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Contract.Core;

/// <summary>
/// Describes an object of any kind. The <c>Object</c> type serves as the 
/// base type for most of the other kinds of objects defined in the 
/// Activity Vocabulary, including other Core types such as <c>Activity</c> (here implemented as <see cref="IActivity"/>), 
/// <c>IntransitiveActivity</c> (here implemented as <see cref="IIntrasitiveActivity"/>), <c>Collection</c> (here implemented as <see cref="ICollection"/>) and 
/// <c>OrderedCollection</c> (here implemented as <see cref="IOrderedCollection"/>).
/// <a href="https://www.w3.org/ns/activitystreams#Object">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Object",
///   "id": "http://www.test.example/object/1",
///   "name": "A Simple, non-specific object"
/// }
/// </code>
/// </example>
public interface IObject : ICoreType
{
    /// <inheritdoc cref="ICoreType.Type" />
    new ObjectType[]? Type { get; }

    /// <summary>
    /// Identifies a resource attached or related to an object that 
    /// potentially requires special handling. The intent is to provide 
    /// a model that is at least semantically similar to attachments in 
    /// email. Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#attachment">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Attachment { get; }

    /// <summary>
    /// Identifies one or more entities that represent the total 
    /// population of entities for which the object can considered 
    /// to be relevant.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#audience">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Audience { get; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. 
    /// By default, the value of content is HTML.The <c>mediaType</c> property can be used in the object 
    /// to indicate a different content type.<br/>
    /// The content may be expressed using multiple language-tagged values.
    /// <a href="https://www.w3.org/ns/activitystreams#content">See w3.org for further details.</a>
    /// </summary>
    string[]? Content { get; } // TODO serialise xsd:string | rdf:langString

    /// <summary>
    /// The date and time describing the actual or expected ending time of the object. When used 
    /// with an Activity object, for instance, the endTime property specifies the moment the 
    /// activity concluded or is expected to conclude.
    /// <a href="https://www.w3.org/ns/activitystreams#endTime">See w3.org for further details.</a>
    /// </summary>
    DateTime? EndTime { get; } // todo xsd:dateTime

    /// <summary>
    /// Identifies the entity (e.g. an application) that generated the object.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#generator">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Generator { get; }

    /// <summary>
    /// Indicates an entity that describes an icon for this object. The image should have an aspect 
    /// ratio of one (horizontal) to one (vertical) and should be suitable for presentation at a 
    /// small size.
    /// Must be either <see cref="IImage"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#icon">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Icon { get; }

    /// <summary>
    /// Indicates an entity that describes an image for this object. Unlike the icon property, 
    /// there are no aspect ratio or display size limitations assumed.
    /// Must be either <see cref="IImage"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#image">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Image { get; }

    /// <summary>
    /// Indicates one or more entities for which this object is considered a response.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#inReplyTo">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? InReplyTo { get; }

    /// <summary>
    /// Indicates one or more physical or logical locations associated with the object.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#location">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Location { get; }

    /// <summary>
    /// The date and time at which the object was published
    /// <a href="https://www.w3.org/ns/activitystreams#published">See w3.org for further details.</a>
    /// </summary>
    DateTime? Published { get; } // TODO 	xsd:dateTime

    /// <summary>
    /// Identifies a <c>Collection</c> containing objects considered to be responses to this object.
    /// <a href="https://www.w3.org/ns/activitystreams#replies">See w3.org for further details.</a>
    /// </summary>
    ICollection? Replies { get; }

    /// <summary>
    /// The date and time describing the actual or expected starting time of the object. When used 
    /// with an <c>Activity</c> object, for instance, the <c>startTime</c> property specifies the moment the 
    /// activity began or is scheduled to begin.
    /// <a href="https://www.w3.org/ns/activitystreams#startTime">See w3.org for further details.</a>
    /// </summary>
    DateTime? StartTime { get; } // TODO 	xsd:dateTime

    /// <summary>
    /// A natural language summarization of the object encoded as HTML. Multiple language tagged
    /// summaries <b>may</b> be provided.
    /// <a href="https://www.w3.org/ns/activitystreams#summary">See w3.org for further details.</a>
    /// </summary>
    string[]? Summary { get; } // TODO xsd:string | rdf:langString

    /// <summary>
    /// One or more "tags" that have been associated with an objects. A tag can be any 
    /// kind of Object. The key difference between <c>attachment</c> and <c>tag</c> is that the 
    /// former implies association by inclusion, while the latter implies associated 
    /// by reference.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#tag">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Tag { get; }

    /// <summary>
    /// The date and time at which the object was updated
    /// <a href="https://www.w3.org/ns/activitystreams#updated">See w3.org for further details.</a>
    /// </summary>
    /// <example>"2014-12-12T12:12:12Z"</example>
    DateTime? Updated { get; } // TODO xsd:dateTime

    /// <summary>
    /// Identifies one or more links to representations of the object
    /// Must be either <c>xsd:anyURI</c> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#tag">See w3.org for further details.</a>
    /// </summary>
    object[]? Url { get; } // TODO serialiser

    /// <summary>
    /// Identifies an entity considered to be part of the public primary audience of an Object
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#to">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? To { get; }

    /// <summary>
    /// Identifies an Object that is part of the private primary 
    /// audience of this Object.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#bto">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Bto { get; }

    /// <summary>
    /// Identifies an Object that is part of the public secondary 
    /// audience of this Object.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#cc">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Cc { get; }

    /// <summary>
    /// Identifies one or more Objects that are part of the private 
    /// secondary audience of this Object.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#bcc">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Bcc { get; }

    /// <summary>
    /// When the object describes a time-bound resource, such as an audio or video, a meeting, etc, 
    /// the <c>duration</c> property indicates the object's approximate duration. The value <b>must</b> be expressed 
    /// as an xsd:duration as defined by <a href="https://www.w3.org/TR/activitystreams-vocabulary/#bib-xmlschema11-2">xmlschema11-2</a>, section 3.3.6 (e.g. a period of 5 seconds 
    /// is represented as "PT5S").
    /// </summary>
    string[]? Duration { get; } // TODO type xsd:duration
}