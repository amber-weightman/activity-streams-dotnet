using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IEvent" />
public record Event : Core.Object, IEvent
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Event };
}
