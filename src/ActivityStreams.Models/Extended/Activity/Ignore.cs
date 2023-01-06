using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IIgnore" />
public record Ignore : Core.Activity.Activity, IIgnore
{
    /// <summary>
    /// Constructor for <see cref="Ignore"/>
    /// </summary>
    [JsonConstructor]
    public Ignore(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Ignore"/>
    /// </summary>
    public Ignore(ICoreType context) : base(context)
    {
    }
}
