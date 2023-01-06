using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IAnnounce" />
public record Announce : Core.Activity.Activity, IAnnounce
{
    /// <summary>
    /// Constructor for <see cref="Announce"/>
    /// </summary>
    [JsonConstructor]
    public Announce(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Announce"/>
    /// </summary>
    public Announce(ICoreType context) : base(context)
    {
    }
}
