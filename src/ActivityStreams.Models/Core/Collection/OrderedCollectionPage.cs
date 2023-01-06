using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollectionPage" />
public record OrderedCollectionPage : CollectionPage, IOrderedCollectionPage, IOrderedCollection, ICollectionPage, ICollection, IObject, ICoreType
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.OrderedCollectionPage };

    /// <inheritdoc cref="IOrderedCollectionPage.StartIndex" />
    public int? StartIndex { get; init; }
}