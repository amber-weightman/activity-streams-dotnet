using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollectionPage" />
public record OrderedCollectionPage : CollectionPage, IOrderedCollectionPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.OrderedCollectionPage };

    /// <inheritdoc cref="IOrderedCollectionPage.StartIndex" />
    [Range(0, int.MaxValue)]
    public int? StartIndex { get; init; }
}