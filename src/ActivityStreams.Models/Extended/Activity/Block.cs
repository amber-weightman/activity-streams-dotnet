using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IBlock" />
public record Block : Ignore, IBlock
{
    /// <summary>
    /// Constructor for <see cref="Block"/>
    /// </summary>
    [JsonConstructor]
    public Block(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Block"/>
    /// </summary>
    public Block(ICoreType context) : base(context)
    {
    }
}
