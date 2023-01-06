using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IOffer" />
public record Offer : Core.Activity.Activity, IOffer
{
    /// <summary>
    /// Constructor for <see cref="Offer"/>
    /// </summary>
    [JsonConstructor]
    public Offer(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Offer"/>
    /// </summary>
    public Offer(ICoreType context) : base(context)
    {
    }
}
