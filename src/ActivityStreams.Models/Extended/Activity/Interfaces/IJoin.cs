using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// Indicates that the <c>actor</c> has joined the <c>object</c>. The <c>target</c> 
/// and <c>origin</c> typically have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Join">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally joined a group",
///   "type": "Join",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Group",
///     "name": "A Simple Group"
///   }
/// }
/// </code>
/// </example>
public interface IJoin : IActivity
{
}
