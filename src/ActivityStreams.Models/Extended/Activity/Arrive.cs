using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Models.Core.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IArrive" />
public record Arrive : IntrasitiveActivity, IArrive
{
    /// <summary>
    /// Constructor for <see cref="Arrive"/>
    /// </summary>
    [JsonConstructor]
    public Arrive(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Arrive"/>
    /// </summary>
    public Arrive(ICoreType context) : base(context)
    {
    }
}
