using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> is calling the <c>target</c>'s attention the <c>object</c>.<br/>
/// The <c>origin</c> typically has no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Announce">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally announced that she had arrived at work",
///   "type": "Announce",
///   "actor": {
///     "type": "Person",
///     "id": "http://sally.example.org",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Arrive",
///     "actor": "http://sally.example.org",
///     "location": {
///         "type": "Place",
///       "name": "Work"
///     }
///   }
/// }
/// </code>
/// </example>
public interface IAnnounce : IActivity, IActivityBase, IObject, ICoreType
{
}
