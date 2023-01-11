using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using ActivityStreams.Models.Core.Activity;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IArrive" />
public record Arrive : IntrasitiveActivity, IArrive
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Arrive) };
}
