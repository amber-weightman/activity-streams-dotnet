using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="ITombstone" />
public record Tombstone : Core.Object, ITombstone
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Tombstone) };

    /// <inheritdoc cref="ITombstone.FormerType" />
    public IObject[]? FormerType { get; init; }

    /// <inheritdoc cref="ITombstone.Deleted" />
    public DateTimeXsd? Deleted { get; init; }
}
