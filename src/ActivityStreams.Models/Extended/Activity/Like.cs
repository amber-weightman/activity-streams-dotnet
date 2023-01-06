using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ILike" />
public record Like : Core.Activity.Activity, ILike
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Like };
}
