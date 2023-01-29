using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// Indicates that the <c>actor</c> is undoing the <c>object</c>. In most 
/// cases, the <c>object</c> will be an <c>Activity</c> (here implemented as <see cref="IActivity"/>) describing some 
/// previously performed action (for instance, a person may 
/// have previously "liked" an article but, for whatever 
/// reason, might choose to undo that like at some later 
/// point in time).<br/>
/// The <c>target</c> and <c>origin</c> typically have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Undo">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally retracted her offer to John",
///   "type": "Undo",
///   "actor": "http://sally.example.org",
///   "object": {
///     "type": "Offer",
///     "actor": "http://sally.example.org",
///     "object": "http://example.org/posts/1",
///     "target": "http://john.example.org"
///   }
/// }
/// </code>
/// </example>
public interface IUndo : IActivity
{
}
