using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="IOrderedCollectionPage" />
public record OrderedCollectionPage : CollectionPage, IOrderedCollectionPage, IOrderedCollection, ICollectionPage, ICollection, IObject, ICoreType
{
    public virtual new CollectionType? Type { get; init; } = CollectionType.OrderedCollectionPage;

    public string? StartIndex { get; init; }
}