namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// A specialization of <c>Reject</c> (here implemented as <see cref="IReject"/>) in which the rejection is 
/// considered tentative.
/// <a href="https://www.w3.org/ns/activitystreams#TentativeReject">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally tentatively rejected an invitation to a party",
///   "type": "TentativeReject",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Invite",
///     "actor": "http://john.example.org",
///     "object": {
///         "type": "Event",
///         "name": "Going-Away Party for Jim"
///     }
///   }
/// }
/// </code>
/// </example>
public interface ITentativeReject : IReject
{
}
