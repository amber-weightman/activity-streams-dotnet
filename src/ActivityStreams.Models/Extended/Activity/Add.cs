using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IAdd" />
public record Add : Core.Activity.Activity, IAdd
{
    /// <summary>
    /// Constructor for <see cref="Add"/>
    /// </summary>
    [JsonConstructor]
    public Add(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Add"/>
    /// </summary>
    public Add(ICoreType context) : base(context)
    {
    }
}
