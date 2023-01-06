namespace ActivityStreams.Contract.Core.Collection;

/// <summary>
/// Used to represent distinct subsets of items from a <c>Collection</c> (here implemented as <see cref="ICollection"/>). 
/// Refer to the <a href="https://www.w3.org/TR/activitystreams-core/#collection">Activity Streams 2.0 Core</a> specification for a complete description 
/// of the <c>CollectionPage</c> object.
/// <a href="https://www.w3.org/ns/activitystreams#CollectionPage">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Page 1 of Sally's notes",
///   "type": "CollectionPage",
///   "id": "http://example.org/foo?page=1",
///   "partOf": "http://example.org/foo",
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
public interface ICollectionPage : ICollection, IObject, ICoreType
{
    /// <summary>
    /// Identifies the Collection to which a CollectionPage objects items belong.
    /// Must be either <see cref="ILink"/> or <see cref="ICollection"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#partOf">See w3.org for further details.</a>
    /// </summary>
    ICoreType? PartOf { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="ICollection"/>), 
    /// indicates the next page of items.
    /// Must be either <see cref="ICollectionPage"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#next">See w3.org for further details.</a>
    /// </summary>
    ICoreType? Next { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="ICollection"/>),
    /// identifies the previous page of items.
    /// </summary>
    ICoreType? Prev { get; }
}