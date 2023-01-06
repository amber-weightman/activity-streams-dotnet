using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IFollow" />
public record Follow : Core.Activity.Activity, IFollow
{
    /// <summary>
    /// Constructor for <see cref="Follow"/>
    /// </summary>
    [JsonConstructor]
    public Follow(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Follow"/>
    /// </summary>
    public Follow(ICoreType context) : base(context)
    {
    }
}
