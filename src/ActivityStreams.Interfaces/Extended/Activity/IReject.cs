using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> is rejecting the <c>object</c>. The <c>target</c> 
/// and <c>origin</c> typically have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Reject">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally rejected an invitation to a party",
///   "type": "Reject",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Invite",
///     "actor": "http://john.example.org",
///     "object": {
///         "type": "Event",
///       "name": "Going-Away Party for Jim"
///     }
///   }
/// }
/// </code>
/// </example>
public interface IReject : IActivity, IActivityBase, IObject, ICoreType
{
}
