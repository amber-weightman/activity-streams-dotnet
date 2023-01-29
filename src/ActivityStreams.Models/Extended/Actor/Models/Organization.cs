using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Extended.Actor.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Actor.Models;

/// <inheritdoc cref="IOrganization" />
public record Organization : StreamsObject, IOrganization
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Organization) };
}
