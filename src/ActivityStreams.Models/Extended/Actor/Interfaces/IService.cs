using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Extended.Actor.Interfaces;

/// <summary>
/// Represents a service of any kind.
/// <a href="https://www.w3.org/ns/activitystreams#Service">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Service",
///   "name": "Acme Web Service"
/// }
/// </code>
/// </example>
public interface IService : IStreamsObject
{
}
