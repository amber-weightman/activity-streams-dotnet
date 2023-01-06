using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollectionPage" />
public record OrderedCollectionPage : CollectionPage, IOrderedCollectionPage, IOrderedCollection, ICollectionPage, ICollection, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="OrderedCollectionPage"/>
    /// </summary>
    [JsonConstructor]
    public OrderedCollectionPage(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="OrderedCollectionPage"/>
    /// </summary>
    public OrderedCollectionPage(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="ICollection.Type" />
    public virtual new CollectionType[]? Type { get; init; } = new[] { CollectionType.OrderedCollectionPage };

    /// <inheritdoc cref="IOrderedCollectionPage.StartIndex" />
    public int? StartIndex { get; init; }
}