using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Collection.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Types;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Core.Collection.Models;

/// <inheritdoc cref="IOrderedStreamsCollectionPage" />
public record OrderedStreamsCollectionPage : StreamsCollectionPage, IOrderedStreamsCollectionPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.OrderedCollectionPage) };

    /// <inheritdoc cref="IOrderedStreamsCollectionPage.StartIndex" />
    [Range(0, int.MaxValue)]
    public int? StartIndex { get; init; }

    /// <inheritdoc cref="IOrderedStreamsCollection.OrderedItems" />
    public ICoreType[]? OrderedItems
    {
        get { return Items; }
        init { Items = value; }
    }
}