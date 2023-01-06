using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// A specialization of <c>Offer</c> (here implemented as <see cref="IOffer"/>) in which the <c>actor</c> is extending 
/// an invitation for the <c>object</c> to the <c>target</c>.
/// <a href="https://www.w3.org/ns/activitystreams#Invite">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally invited John and Lisa to a party",
///   "type": "Invite",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Event",
///     "name": "A Party"
///   },
///   "target": [
///     {
///       "type": "Person",
///       "name": "John"
///     },
///     {
///       "type": "Person",
///       "name": "Lisa"
///     }
///   ]
/// }
/// </code>
/// </example>
public interface IInvite : IOffer, IActivity, IActivityBase, IObject, ICoreType
{
}
