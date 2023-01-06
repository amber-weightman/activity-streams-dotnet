namespace ActivityStreams.Contract.Core.Collection;

/// <summary>
/// Used to represent ordered subsets of items from an 
/// <c>OrderedCollection</c> (here implemented as <see cref="IOrderedCollection"/>). 
/// Refer to the <a href="https://www.w3.org/TR/activitystreams-core/#collection">Activity Streams 2.0 Core</a> specification for a 
/// complete description of the <c>OrderedCollectionPage</c> object.
/// <a href="https://www.w3.org/ns/activitystreams#OrderedCollectionPage">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Page 1 of Sally's notes",
///   "type": "OrderedCollectionPage",
///   "id": "http://example.org/foo?page=1",
///   "partOf": "http://example.org/foo",
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
public interface IOrderedCollectionPage : IOrderedCollection, ICollectionPage, ICollection, IObject, ICoreType
{
    /// <summary>
    /// A non-negative integer value identifying the relative position 
    /// within the logical view of a strictly ordered collection.
    /// </summary>
    int? StartIndex { get; } // TODO >0
}