using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ICreate" />
public record Create : Core.Activity.Activity, ICreate
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Create) };
}
