using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IOrganization" />
public record Organization : Core.Object, IOrganization
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Organization };
}
