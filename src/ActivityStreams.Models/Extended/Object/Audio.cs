using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IAudio" />
public record Audio : Document, IAudio
{
    /// <summary>
    /// Constructor for <see cref="Audio"/>
    /// </summary>
    [JsonConstructor]
    public Audio(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Audio"/>
    /// </summary>
    public Audio(ICoreType context) : base(context)
    {
    }
}
