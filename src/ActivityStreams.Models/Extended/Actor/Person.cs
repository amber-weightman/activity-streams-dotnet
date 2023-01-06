using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IPerson" />
public record Person : Core.Object, IPerson
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Person };
}
