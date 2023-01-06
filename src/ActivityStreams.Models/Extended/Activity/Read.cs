using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IRead" />
public record Read : Core.Activity.Activity, IRead
{
    /// <summary>
    /// Constructor for <see cref="Read"/>
    /// </summary>
    [JsonConstructor]
    public Read(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Read"/>
    /// </summary>
    public Read(ICoreType context) : base(context)
    {
    }
}
