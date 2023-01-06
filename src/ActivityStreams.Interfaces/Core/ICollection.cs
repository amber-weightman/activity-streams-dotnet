namespace ActivityStreams.Contract.Core;

/// <summary>
/// A <c>Collection</c> is a subtype of <c>Object</c> (here implemented as <see cref="IObject"/>) that represents ordered or 
/// unordered sets of <c>Object</c> or <c>Link</c> (here implemented as <see cref="ILink"/>) instances.<br/>
/// Refer to the <a href="https://www.w3.org/TR/activitystreams-core/#collection">Activity Streams 2.0 Core</a> specification for a complete 
/// description of the Collection type.
/// <a href="https://www.w3.org/ns/activitystreams#Collection">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally's notes",
///   "type": "Collection",
///   "totalItems": 2,
///   "items": [
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
public interface ICollection : IObject, ICoreType
{
    /// <summary>
    /// 	A non-negative integer specifying the total number of objects contained by the 
    /// 	logical view of the collection. This number might not reflect the actual number of 
    /// 	items serialized within the Collection object instance.
    /// <a href="https://www.w3.org/ns/activitystreams#totalItems">See w3.org for further details.</a>
    /// </summary>
    int? TotalItems { get; } // TODO >=0

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="ICollection"/>), 
    /// indicates the page that contains the most recently updated 
    /// member items.
    /// Must be either <see cref="ICollectionPage"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#current">See w3.org for further details.</a>
    /// </summary>
    ICoreType? Current { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="ICollection"/>), 
    /// indicates the furthest preceeding page of items in the collection.
    /// Must be either <see cref="ICollectionPage"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#first">See w3.org for further details.</a>
    /// </summary>
    ICoreType? First { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="ICollection"/>), 
    /// indicates the furthest proceeding page of the collection.
    /// Must be either <see cref="ICollectionPage"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#first">See w3.org for further details.</a>
    /// </summary>
    ICoreType? Last { get; }

    /// <summary>
    /// Identifies the items contained in a collection. The items might be ordered or unordered.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/> or <see cref="IOrderedCollection"/> of the same.
    /// <a href="https://www.w3.org/ns/activitystreams#items">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Items { get; }
}