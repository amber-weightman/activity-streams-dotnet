using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ITentativeReject" />
public record TentativeReject : Reject, ITentativeReject
{
    /// <summary>
    /// Constructor for <see cref="TentativeReject"/>
    /// </summary>
    [JsonConstructor]
    public TentativeReject(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="TentativeReject"/>
    /// </summary>
    public TentativeReject(ICoreType context) : base(context)
    {
    }
}
