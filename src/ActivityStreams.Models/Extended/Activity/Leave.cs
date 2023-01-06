using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ILeave" />
public record Leave : Core.Activity.Activity, ILeave
{
    /// <summary>
    /// Constructor for <see cref="Leave"/>
    /// </summary>
    [JsonConstructor]
    public Leave(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Leave"/>
    /// </summary>
    public Leave(ICoreType context) : base(context)
    {
    }
}
