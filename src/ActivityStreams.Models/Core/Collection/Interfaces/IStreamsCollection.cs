using ActivityStreams.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Core.Collection.Interfaces;

/// <summary>
/// A <c>Collection</c> is a subtype of <c>Object</c> (here implemented as <see cref="IStreamsObject"/>) that represents ordered or 
/// unordered sets of <c>Object</c> or <c>Link</c> (here implemented as <see cref="IStreamsLink"/>) instances.<br/>
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
public interface IStreamsCollection : IStreamsObject
{
    /// <summary>
    ///  A non-negative integer specifying the total number of objects contained by the 
    /// logical view of the collection. This number might not reflect the actual number of 
    /// items serialized within the <c>Collection</c> (here implemented as <see cref="IStreamsCollection"/>) object instance.
    /// <a href="https://www.w3.org/ns/activitystreams#totalItems">See w3.org for further details.</a>
    /// </summary>
    [Range(0, int.MaxValue)]
    int? TotalItems { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="IStreamsCollection"/>), 
    /// indicates the page that contains the most recently updated 
    /// member items.
    /// Must be either <see cref="IStreamsCollectionPage"/> or <see cref="IStreamsLink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#current">See w3.org for further details.</a>
    /// </summary>
    ICoreType? Current { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="IStreamsCollection"/>), 
    /// indicates the furthest preceeding page of items in the collection.
    /// Must be either <see cref="IStreamsCollectionPage"/> or <see cref="IStreamsLink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#first">See w3.org for further details.</a>
    /// </summary>
    ICoreType? First { get; }

    /// <summary>
    /// In a paged <c>Collection</c> (here implemented as <see cref="IStreamsCollection"/>), 
    /// indicates the furthest proceeding page of the collection.
    /// Must be either <see cref="IStreamsCollectionPage"/> or <see cref="IStreamsLink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#first">See w3.org for further details.</a>
    /// </summary>
    ICoreType? Last { get; }

    /// <summary>
    /// Identifies the items contained in a collection. The items might be ordered or unordered.
    /// Must be either <see cref="IStreamsObject"/> or <see cref="IStreamsLink"/> or <see cref="IOrderedStreamsCollection"/> of the same.
    /// <a href="https://www.w3.org/ns/activitystreams#items">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Items { get; }
}