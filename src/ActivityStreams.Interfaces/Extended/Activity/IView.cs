using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has viewed the <c>object</c>.
/// <a href="https://www.w3.org/ns/activitystreams#View">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally read an article",
///   "type": "View",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Article",
///     "name": "What You Should Know About Activity Streams"
///   }
/// }
/// </code>
/// </example>
public interface IView : IActivity, IActivityBase, IObject, ICoreType
{
}
