using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollection" />
public record OrderedCollection : Collection, IOrderedCollection
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.OrderedCollection) };

    /// <inheritdoc cref="IOrderedCollection.OrderedItems" />
    public ICoreType[]? OrderedItems
    {
        get { return Items; }
        init { Items = value; }
    }
}