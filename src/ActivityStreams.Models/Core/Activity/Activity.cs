using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IActivity" />
public record Activity : ActivityBase, IActivity, IObject, ICoreType
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Activity };

    /// <inheritdoc cref="IActivity.Object" />
    public ICoreType[]? Object { get; init; }
}