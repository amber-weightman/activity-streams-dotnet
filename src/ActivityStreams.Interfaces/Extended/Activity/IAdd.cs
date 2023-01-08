using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has added the <c>object</c> to the 
/// target. If the <c>target</c> property is not explicitly 
/// specified, the target would need to be determined 
/// implicitly by context. The <c>origin</c> can be used to 
/// identify the context from which the <c>object</c> originated.
/// <a href="https://www.w3.org/ns/activitystreams#Add">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally added an object",
///   "type": "Add",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/abc"
/// }
/// </code>
/// </example>
public interface IAdd : IActivity
{
}
