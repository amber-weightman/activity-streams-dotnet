using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IVideo" />
public record Video : Document, IVideo
{
    /// <summary>
    /// Constructor for <see cref="Video"/>
    /// </summary>
    [JsonConstructor]
    public Video(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Video"/>
    /// </summary>
    public Video(ICoreType context) : base(context)
    {
    }
}
