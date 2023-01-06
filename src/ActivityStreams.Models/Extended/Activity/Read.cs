using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IRead" />
public record Read : Core.Activity.Activity, IRead
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Read };
}
