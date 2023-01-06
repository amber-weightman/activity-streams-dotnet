using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has listened to the <c>object</c>.
/// <a href="https://www.w3.org/ns/activitystreams#Listen">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally listened to a piece of music",
///   "type": "Listen",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/music.mp3"
/// }
/// </code>
/// </example>
public interface IListen : IActivity, IActivityBase, IObject, ICoreType
{
}
