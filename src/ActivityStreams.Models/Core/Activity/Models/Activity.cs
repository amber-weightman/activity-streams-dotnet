using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Activity.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Core.Activity.Models;

/// <inheritdoc cref="IActivity" />
public record Activity : ActivityBase, IActivity
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Activity) };

    /// <inheritdoc cref="IActivity.Object" />
    public ICoreType[]? Object { get; init; }
}