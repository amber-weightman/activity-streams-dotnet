using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IInvite" />
public record Invite : Offer, IInvite
{
    /// <summary>
    /// Constructor for <see cref="Invite"/>
    /// </summary>
    [JsonConstructor]
    public Invite(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Invite"/>
    /// </summary>
    public Invite(ICoreType context) : base(context)
    {
    }
}
