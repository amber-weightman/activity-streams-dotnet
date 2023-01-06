using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IMove" />
public record Move : Core.Activity.Activity, IMove
{
    /// <summary>
    /// Constructor for <see cref="Move"/>
    /// </summary>
    [JsonConstructor]
    public Move(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Move"/>
    /// </summary>
    public Move(ICoreType context) : base(context)
    {
    }
}
