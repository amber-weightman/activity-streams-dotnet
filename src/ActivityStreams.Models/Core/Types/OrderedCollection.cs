using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="IOrderedCollection" />
public record OrderedCollection : Collection, IOrderedCollection, ICollection, IObject, ICoreType 
{
    public virtual new CollectionType? Type { get; init; } = CollectionType.OrderedCollection;
}