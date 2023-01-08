using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> accepts the <c>object</c>. The <c>target</c> 
/// property can be used in certain circumstances to indicate 
/// the context into which the <c>object</c> has been accepted.
/// <a href="https://www.w3.org/ns/activitystreams#Accept">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally accepted an invitation to a party",
///   "type": "Accept",
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
public interface IAccept : IActivity
{
}
