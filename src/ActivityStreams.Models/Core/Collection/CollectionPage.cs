using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="ICollectionPage" />
public record CollectionPage : Collection, ICollectionPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.CollectionPage };

    /// <inheritdoc cref="ICollectionPage.PartOf" />
    public ICoreType? PartOf { get; init; }

    /// <inheritdoc cref="ICollectionPage.Next" />
    public ICoreType? Next { get; init; }

    /// <inheritdoc cref="ICollectionPage.Prev" />
    public ICoreType? Prev { get; init; }
}