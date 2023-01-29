using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Extended.Object.Interfaces;

/// <summary>
/// Represents any kind of event.
/// <a href="https://www.w3.org/ns/activitystreams#Event">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Event",
///   "name": "Going-Away Party for Jim",
///   "startTime": "2014-12-31T23:00:00-08:00",
///   "endTime": "2015-01-01T06:00:00-08:00"
/// }
/// </code>
/// </example>
public interface IEvent : IStreamsObject
{
}
