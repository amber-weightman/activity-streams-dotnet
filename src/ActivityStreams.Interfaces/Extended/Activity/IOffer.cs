using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> is offering the <c>object</c>. If 
/// specified, the <c>target</c> indicates the entity to which 
/// the <c>object</c> is being offered.
/// <a href="https://www.w3.org/ns/activitystreams#Offer">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally offered 50% off to Lewis",
///   "type": "Offer",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "http://www.types.example/ProductOffer",
///     "name": "50% Off!"
///   },
///   "target": {
///     "type": "Person",
///     "name": "Lewis"
///   }
/// }
/// </code>
/// </example>
public interface IOffer : IActivity, IActivityBase, IObject, ICoreType
{
}
