using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IRemove" />
public record Remove : Core.Activity.Activity, IRemove
{
    /// <summary>
    /// Constructor for <see cref="Remove"/>
    /// </summary>
    [JsonConstructor]
    public Remove(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Remove"/>
    /// </summary>
    public Remove(ICoreType context) : base(context)
    {
    }
}
