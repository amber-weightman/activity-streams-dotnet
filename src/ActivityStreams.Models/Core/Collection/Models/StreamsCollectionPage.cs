using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Collection.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Core.Collection.Models;

/// <inheritdoc cref="IStreamsCollectionPage" />
public record StreamsCollectionPage : StreamsCollection, IStreamsCollectionPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.CollectionPage) };

    /// <inheritdoc cref="IStreamsCollectionPage.PartOf" />
    public ICoreType? PartOf { get; init; }

    /// <inheritdoc cref="IStreamsCollectionPage.Next" />
    public ICoreType? Next { get; init; }

    /// <inheritdoc cref="IStreamsCollectionPage.Prev" />
    public ICoreType? Prev { get; init; }
}