using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IGroup" />
public record Group: Core.Object, IGroup
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Group };
}
