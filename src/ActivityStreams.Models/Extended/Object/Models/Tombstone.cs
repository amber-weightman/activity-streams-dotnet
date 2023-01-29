using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Extended.Object.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Object.Models;

/// <inheritdoc cref="ITombstone" />
public record Tombstone : StreamsObject, ITombstone
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Tombstone) };

    /// <inheritdoc cref="ITombstone.FormerType" />
    public IStreamsObject[]? FormerType { get; init; }

    /// <inheritdoc cref="ITombstone.Deleted" />
    public DateTimeXsd? Deleted { get; init; }
}
