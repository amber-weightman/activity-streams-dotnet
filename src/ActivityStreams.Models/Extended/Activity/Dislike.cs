using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IDislike" />
public record Dislike : Core.Activity.Activity, IDislike
{
    /// <summary>
    /// Constructor for <see cref="Dislike"/>
    /// </summary>
    [JsonConstructor]
    public Dislike(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Dislike"/>
    /// </summary>
    public Dislike(ICoreType context) : base(context)
    {
    }
}
