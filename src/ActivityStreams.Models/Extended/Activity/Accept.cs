using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="Core.Activity.Activity" />
public record Accept : Core.Activity.Activity, IAccept
{
    /// <summary>
    /// Constructor for <see cref="Accept"/>
    /// </summary>
    [JsonConstructor]
    public Accept(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Accept"/>
    /// </summary>
    public Accept(ICoreType context) : base(context)
    {
    }
}
