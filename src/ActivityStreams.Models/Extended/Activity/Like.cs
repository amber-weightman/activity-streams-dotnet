using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ILike" />
public record Like : Core.Activity.Activity, ILike
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Like) };
}
