using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IDelete" />
public record Delete : Core.Activity.Activity, IDelete
{
    /// <summary>
    /// Constructor for <see cref="Delete"/>
    /// </summary>
    [JsonConstructor]
    public Delete(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Delete"/>
    /// </summary>
    public Delete(ICoreType context) : base(context)
    {
    }
}
