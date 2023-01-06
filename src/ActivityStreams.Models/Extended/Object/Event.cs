using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IEvent" />
public record Event : Core.Object, IEvent
{
    /// <summary>
    /// Constructor for <see cref="Event"/>
    /// </summary>
    [JsonConstructor]
    public Event(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Event"/>
    /// </summary>
    public Event(ICoreType context) : base(context)
    {
    }
}
