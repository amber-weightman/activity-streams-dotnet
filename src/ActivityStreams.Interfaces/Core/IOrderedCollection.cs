namespace ActivityStreams.Contract.Core;

/// <summary>
/// A subtype of <c>Collection</c> (here implemented as <see cref="ICollection"/>) in which members of the logical 
/// collection are assumed to always be strictly ordered.
/// <a href="https://www.w3.org/ns/activitystreams#OrderedCollection">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally's notes",
///   "type": "OrderedCollection",
///   "totalItems": 2,
///   "orderedItems": [
///     {
///       "type": "Note",
///       "name": "A Simple Note"
///     },
///     {
///     "type": "Note",
///       "name": "Another Simple Note"
///     }
///   ]
/// }
/// </code>
/// </example>
public interface IOrderedCollection : ICollection
{
}