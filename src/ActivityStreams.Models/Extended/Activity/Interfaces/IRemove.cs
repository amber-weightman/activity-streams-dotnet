using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// Indicates that the <c>actor</c> is removing the <c>object</c>. If 
/// specified, the <c>origin</c> indicates the context from which 
/// the <c>object</c> is being removed.
/// <a href="https://www.w3.org/ns/activitystreams#Remove">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally removed a note from her notes folder",
///   "type": "Remove",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/notes/1",
///   "target": {
///     "type": "Collection",
///     "name": "Notes Folder"
///   }
/// }
/// </code>
/// </example>
public interface IRemove : IActivity
{
}
