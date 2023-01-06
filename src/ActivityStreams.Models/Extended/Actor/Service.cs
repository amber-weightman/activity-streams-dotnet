using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IService" />
public record Service : Core.Object, IService
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Service };
}
