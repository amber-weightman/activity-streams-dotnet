using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IActivity" />
public record Activity : ActivityBase, IActivity
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Activity) };

    /// <inheritdoc cref="IActivity.Object" />
    public ICoreType[]? Object { get; init; }
}