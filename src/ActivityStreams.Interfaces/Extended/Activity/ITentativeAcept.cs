namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// A specialization of <c>Accept</c> (here implemented as <see cref="IAccept"/>) indicating that the acceptance is 
/// tentative.
/// <a href="https://www.w3.org/ns/activitystreams#TentativeAccept">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally tentatively accepted an invitation to a party",
///   "type": "TentativeAccept",
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
public interface ITentativeAccept : IAccept
{
}
