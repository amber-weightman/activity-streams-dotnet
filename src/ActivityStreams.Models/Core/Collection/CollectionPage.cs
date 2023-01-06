using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="ICollectionPage" />
public record CollectionPage : Collection, ICollectionPage, ICollection, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="CollectionPage"/>
    /// </summary>
    [JsonConstructor]
    public CollectionPage(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="CollectionPage"/>
    /// </summary>
    public CollectionPage(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="ICollection.Type" />
    public virtual new CollectionType[]? Type { get; init; } = new[] { CollectionType.CollectionPage };

    /// <inheritdoc cref="ICollectionPage.PartOf" />
    public ICoreType? PartOf { get; init; }

    /// <inheritdoc cref="ICollectionPage.Next" />
    public ICoreType? Next { get; init; }

    /// <inheritdoc cref="ICollectionPage.Prev" />
    public ICoreType? Prev { get; init; }
}