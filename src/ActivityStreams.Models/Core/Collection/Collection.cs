using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="ICollection" />
public record Collection : Object, ICollection, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="Collection"/>
    /// </summary>
    [JsonConstructor]
    public Collection(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Collection"/>
    /// </summary>
    public Collection(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="ICollection.Type" />
    public virtual new CollectionType[]? Type { get; init; } = new[] { CollectionType.Collection };

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