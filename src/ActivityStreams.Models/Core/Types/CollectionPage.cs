using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="ICollectionPage" />
public record CollectionPage : Collection, ICollectionPage, ICollection, IObject, ICoreType
{
    public virtual new CollectionType? Type { get; init; } = CollectionType.CollectionPage;

    public string? PartOf { get; init; }
    public string? Next { get; init; }
    public string? Prev { get; init; }
}