using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has read the <c>object</c>.
/// <a href="https://www.w3.org/ns/activitystreams#Read">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally read a blog post",
///   "type": "Read",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/posts/1"
/// }
/// </code>
/// </example>
public interface IRead : IActivity, IActivityBase, IObject, ICoreType
{
}
