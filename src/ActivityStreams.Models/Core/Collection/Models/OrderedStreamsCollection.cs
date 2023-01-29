using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Collection.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Core.Collection.Models;

/// <inheritdoc cref="IOrderedStreamsCollection" />
public record OrderedStreamsCollection : StreamsCollection, IOrderedStreamsCollection
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.OrderedCollection) };

    /// <inheritdoc cref="IOrderedStreamsCollection.OrderedItems" />
    public ICoreType[]? OrderedItems
    {
        get { return Items; }
        init { Items = value; }
    }
}