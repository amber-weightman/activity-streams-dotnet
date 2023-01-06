using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IFlag" />
public record Flag : Core.Activity.Activity, IFlag
{
    /// <summary>
    /// Constructor for <see cref="Flag"/>
    /// </summary>
    [JsonConstructor]
    public Flag(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Flag"/>
    /// </summary>
    public Flag(ICoreType context) : base(context)
    {
    }
}
