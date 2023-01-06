using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> dislikes the <c>object</c>.
/// <a href="https://www.w3.org/ns/activitystreams#Dislike">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally disliked a post",
///   "type": "Dislike",
///   "actor": "http://sally.example.org",
///   "object": "http://example.org/posts/1"
/// }
/// </code>
/// </example>
public interface IDislike : IActivity, IActivityBase, IObject, ICoreType
{
}
