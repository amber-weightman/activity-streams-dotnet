using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Extended.Actor.Interfaces;

/// <summary>
/// Represents an individual person.
/// <a href="https://www.w3.org/ns/activitystreams#Person">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Person",
///   "name": "Sally Smith"
/// }
/// </code>
/// </example>
public interface IPerson : IStreamsObject
{
}
