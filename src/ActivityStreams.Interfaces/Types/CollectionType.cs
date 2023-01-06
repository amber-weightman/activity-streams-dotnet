using ActivityStreams.Contract.Core.Collection;

namespace ActivityStreams.Contract.Types;

/// <summary>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#object-types">w3.org</a>.
/// </summary>
public enum CollectionType
{
    /// <summary>
    /// Identifies a <c>collection</c> of general type <see cref="ICollection"/>
    /// </summary>
    Collection,
    /// <summary>
    /// Identifies a <c>collection</c> of type <see cref="ICollectionPage"/>
    /// </summary>
    CollectionPage,
    /// <summary>
    /// Identifies a <c>collection</c> of type <see cref="IOrderedCollection"/>
    /// </summary>
    OrderedCollection,
    /// <summary>
    /// Identifies a <c>collection</c> of type <see cref="IOrderedCollectionPage"/>
    /// </summary>
    OrderedCollectionPage
}
