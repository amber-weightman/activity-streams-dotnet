using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="ICollection" />
public record Collection : Object, ICollection, IObject, ICoreType
{
    public virtual new CollectionType? Type { get; init; } = CollectionType.Collection;

    public string? TotalItems { get; init; }
    public string? Current { get; init; }
    public string? First { get; init; }
    public string? Last { get; init; }
    public string? Items { get; init; }
}