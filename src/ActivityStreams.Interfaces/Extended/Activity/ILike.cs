using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> likes, recommends or endorses 
/// the <c>object</c>. The <c>target</c> and <c>origin</c> typically have no 
/// defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Like">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally liked a note",
///   "type": "Like",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/notes/1"
/// }
/// </code>
/// </example>
public interface ILike : IActivity, IActivityBase, IObject, ICoreType
{
}
