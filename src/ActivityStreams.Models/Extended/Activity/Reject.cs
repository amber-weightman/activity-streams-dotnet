using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IReject" />
public record Reject : Core.Activity.Activity, IReject
{
    /// <summary>
    /// Constructor for <see cref="Reject"/>
    /// </summary>
    [JsonConstructor]
    public Reject(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Reject"/>
    /// </summary>
    public Reject(ICoreType context) : base(context)
    {
    }
}
