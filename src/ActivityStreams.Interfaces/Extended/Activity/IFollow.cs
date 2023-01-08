using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> is "following" the <c>object</c>. 
/// Following is defined in the sense typically used within 
/// Social systems in which the actor is interested in any 
/// activity performed by or on the object. The <c>target</c> and 
/// <c>origin</c> typically have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Follow">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally followed John",
///   "type": "Follow",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Person",
///     "name": "John"
///   }
/// }
/// </code>
/// </example>
public interface IFollow : IActivity
{
}
