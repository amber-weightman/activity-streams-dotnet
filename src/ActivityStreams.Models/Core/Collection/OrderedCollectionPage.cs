using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollectionPage" />
public record OrderedCollectionPage : CollectionPage, IOrderedCollectionPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.OrderedCollectionPage) };

    /// <inheritdoc cref="IOrderedCollectionPage.StartIndex" />
    [Range(0, int.MaxValue)]
    public int? StartIndex { get; init; }

    /// <inheritdoc cref="IOrderedCollection.OrderedItems" />
    public ICoreType[]? OrderedItems
    {
        get { return Items; }
        init { Items = value; }
    }
}