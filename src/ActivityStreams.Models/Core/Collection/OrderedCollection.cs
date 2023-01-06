using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollection" />
public record OrderedCollection : Collection, IOrderedCollection, ICollection, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="OrderedCollection"/>
    /// </summary>
    [JsonConstructor]
    public OrderedCollection(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="OrderedCollection"/>
    /// </summary>
    public OrderedCollection(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="ICollection.Type" />
    public virtual new CollectionType[]? Type { get; init; } = new[] { CollectionType.OrderedCollection };
}