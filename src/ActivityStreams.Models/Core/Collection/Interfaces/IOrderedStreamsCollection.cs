using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Core.Collection.Interfaces;

/// <summary>
/// A subtype of <c>Collection</c> (here implemented as <see cref="IStreamsCollection"/>) in which members of the logical 
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
public interface IOrderedStreamsCollection : IStreamsCollection
{
    /// <summary>
    /// Identifies the items contained in a collection. Items will be ordered.
    /// Must be either <see cref="IStreamsObject"/> or <see cref="IStreamsLink"/> or <see cref="IOrderedStreamsCollection"/> of the same.
    /// <a href="https://www.w3.org/ns/activitystreams#items">See w3.org for further details.</a>
    /// </summary>
    public ICoreType[]? OrderedItems => Items;
}