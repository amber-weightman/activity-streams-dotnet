using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IApplication" />
public record Application : Core.Object, IApplication
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Application };
}
