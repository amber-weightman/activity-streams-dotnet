using ActivityStreams.Contract.Core;
using System.Text.Json.Serialization;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// Describes a relationship between two individuals. The <c>subject</c>
/// and <c>object</c> properties are used to identify the connected 
/// individuals.<br/>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#connections">5.2 Representing Relationships Between Entities</a> for 
/// additional information.
/// <a href="https://www.w3.org/ns/activitystreams#Relationship">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally is an acquaintance of John",
///   "type": "Relationship",
///   "subject": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "relationship": "http://purl.org/vocab/relationship/acquaintanceOf",
///   "object": {
///     "type": "Person",
///     "name": "John"
///   }
/// }
/// </code>
/// </example>
public interface IRelationship : IObject
{
    /// <summary>
    /// On a Relationship object, the subject property identifies one of the connected individuals. 
    /// For instance, for a Relationship object describing "John is related to Sally", subject would refer to John.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#subject">See w3.org for further details.</a>
    /// </summary>
    ICoreType? Subject { get; }

    /// <summary>
    /// When used within a Relationship describes the entity to which the subject 
    /// is related.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#object">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Object { get; }

    /// <summary>
    /// On a Relationship object, the relationship property identifies the kind of relationship that exists between subject and object.
    /// <a href="https://www.w3.org/ns/activitystreams#relationship">See w3.org for further details.</a>
    /// </summary>
    [JsonPropertyName("relationship")]
    IObject[]? InnerRelationship { get; }
}
