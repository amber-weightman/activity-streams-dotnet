using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IImage" />
public record Image : Document, IImage
{
    /// <summary>
    /// Constructor for <see cref="Image"/>
    /// </summary>
    [JsonConstructor]
    public Image(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Image"/>
    /// </summary>
    public Image(ICoreType context) : base(context)
    {
    }
}
