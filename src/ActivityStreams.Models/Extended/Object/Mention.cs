using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Models.Core;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IMention" />
public record Mention : Link, IMention
{
    /// <summary>
    /// Constructor for <see cref="Mention"/>
    /// </summary>
    [JsonConstructor]
    public Mention(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Mention"/>
    /// </summary>
    public Mention(ICoreType context) : base(context)
    {
    }
}
