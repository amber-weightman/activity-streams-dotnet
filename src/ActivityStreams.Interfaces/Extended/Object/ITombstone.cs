using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// A Tombstone represents a content object that has been 
/// deleted. It can be used in <c>Collection</c>s (here implemented as <see cref="ICollection"/>) to signify that 
/// there used to be an object at this position, but it has 
/// been deleted.
/// <a href="https://www.w3.org/ns/activitystreams#Tombstone">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "type": "OrderedCollection",
///   "totalItems": 3,
///   "name": "Vacation photos 2016",
///   "orderedItems": [
///     {
///       "type": "Image",
///       "id": "http://image.example/1"
///     },
///     {
///       "type": "Tombstone",
///       "formerType": "Image",
///       "id": "http://image.example/2",
///       "deleted": "2016-03-17T00:00:00Z"
///     },
///     {
///       "type": "Image",
///       "id": "http://image.example/3"
///     }
///   ]
/// }
/// </code>
/// </example>
public interface ITombstone : IObject, ICoreType
{
    /// <summary>
    ///	On a Tombstone object, the formerType property identifies the type of the 
    ///	object that was deleted.
    /// <a href="https://www.w3.org/ns/activitystreams#formerType">See w3.org for further details.</a>
    /// </summary>
    IObject[]? FormerType { get; }

    /// <summary>
    /// On a Tombstone object, the deleted property is a timestamp for when the 
    /// object was deleted.
    /// <a href="https://www.w3.org/ns/activitystreams#deleted">See w3.org for further details.</a>
    /// </summary>
    DateTimeXsd? Deleted { get; }
}
