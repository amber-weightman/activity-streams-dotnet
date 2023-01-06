using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IJoin" />
public record Join : Core.Activity.Activity, IJoin
{
    /// <summary>
    /// Constructor for <see cref="Join"/>
    /// </summary>
    [JsonConstructor]
    public Join(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Join"/>
    /// </summary>
    public Join(ICoreType context) : base(context)
    {
    }
}
