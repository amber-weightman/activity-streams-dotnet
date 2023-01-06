using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="IOrderedCollection" />
public record OrderedCollection : Collection, IOrderedCollection, ICollection, IObject, ICoreType
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.OrderedCollection };
}