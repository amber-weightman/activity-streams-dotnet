using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="ICollectionPage" />
public record CollectionPage : Collection, ICollectionPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.CollectionPage) };

    /// <inheritdoc cref="ICollectionPage.PartOf" />
    public ICoreType? PartOf { get; init; }

    /// <inheritdoc cref="ICollectionPage.Next" />
    public ICoreType? Next { get; init; }

    /// <inheritdoc cref="ICollectionPage.Prev" />
    public ICoreType? Prev { get; init; }
}