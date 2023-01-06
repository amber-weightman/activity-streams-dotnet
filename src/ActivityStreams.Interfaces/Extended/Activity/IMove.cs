using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has moved <c>object</c> from <c>origin</c> to 
/// <c>target</c>. If the <c>origin</c> or <c>target</c> are not specified, either 
/// can be determined by context.
/// <a href="https://www.w3.org/ns/activitystreams#Move">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally moved a post from List A to List B",
///   "type": "Move",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/posts/1",
///   "target": {
///     "type": "Collection",
///     "name": "List B"
///   },
///   "origin": {
///     "type": "Collection",
///     "name": "List A"
///   }
/// }
/// </code>
/// </example>
public interface IMove : IActivity, IActivityBase, IObject, ICoreType
{
}
