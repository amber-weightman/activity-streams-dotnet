using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="ICollection" />
public record Collection : Object, ICollection
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Collection };

    /// <inheritdoc cref="ICollection.TotalItems" />
    public int? TotalItems { get; init; }

    /// <inheritdoc cref="ICollection.Current" />
    public ICoreType? Current { get; init; }

    /// <inheritdoc cref="ICollection.First" />
    public ICoreType? First { get; init; }

    /// <inheritdoc cref="ICollection.Last" />
    public ICoreType? Last { get; init; }

    /// <inheritdoc cref="ICollection.Items" />
    public ICoreType[]? Items { get; init; }
}