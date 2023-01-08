using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// https://www.w3.org/ns/activitystreams#Mention<br/>
/// A specialized <c>Link</c> (here implemented as <see cref="ILink"/>) that represents an @mention.
/// <a href="https://www.w3.org/ns/activitystreams#Mention">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Mention of Joe by Carrie in her note",
///   "type": "Mention",
///   "href": "http://example.org/joe",
///   "name": "Joe"
/// }
/// </code>
/// </example>
public interface IMention: ILink
{
}
