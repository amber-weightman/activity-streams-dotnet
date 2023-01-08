using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has deleted the <c>object</c>. If 
/// specified, the <c>origin</c> indicates the context from which 
/// the <c>object</c> was deleted.
/// <a href="https://www.w3.org/ns/activitystreams#Delete">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally deleted a note",
///   "type": "Delete",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/notes/1",
///   "origin": {
///     "type": "Collection",
///     "name": "Sally's Notes"
///   }
/// }
/// </code>
/// </example>
public interface IDelete : IActivity
{
}
