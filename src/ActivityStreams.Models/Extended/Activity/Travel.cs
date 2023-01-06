using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Core.Activity;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ITravel" />
public record Travel : IntrasitiveActivity, ITravel
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Travel };
}
