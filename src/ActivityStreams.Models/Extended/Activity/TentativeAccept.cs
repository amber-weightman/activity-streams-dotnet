using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ITentativeAccept" />
public record TentativeAccept : Accept, ITentativeAccept
{
    /// <summary>
    /// Constructor for <see cref="TentativeAccept"/>
    /// </summary>
    [JsonConstructor]
    public TentativeAccept(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="TentativeAccept"/>
    /// </summary>
    public TentativeAccept(ICoreType context) : base(context)
    {
    }
}
