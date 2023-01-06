using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IUpdate" />
public record Update : Core.Activity.Activity, IUpdate
{
    /// <summary>
    /// Constructor for <see cref="Update"/>
    /// </summary>
    [JsonConstructor]
    public Update(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Update"/>
    /// </summary>
    public Update(ICoreType context) : base(context)
    {
    }
}
