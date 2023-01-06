using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IInvite" />
public record Invite : Offer, IInvite
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Invite };
}
