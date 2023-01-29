using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// Indicates that the <c>actor</c> is ignoring the <c>object</c>. The <c>target</c> 
/// and <c>origin</c> typically have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Ignore">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally ignored a note",
///   "type": "Ignore",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/notes/1"
/// }
/// </code>
/// </example>
public interface IIgnore : IActivity
{
}
