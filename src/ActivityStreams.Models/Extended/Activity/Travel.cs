using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Models.Core.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ITravel" />
public record Travel : IntrasitiveActivity, ITravel
{
    /// <summary>
    /// Constructor for <see cref="Travel"/>
    /// </summary>
    [JsonConstructor]
    public Travel(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Travel"/>
    /// </summary>
    public Travel(ICoreType context) : base(context)
    {
    }
}
