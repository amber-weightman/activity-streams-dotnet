using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ICreate" />
public record Create : Core.Activity.Activity, ICreate
{
    /// <summary>
    /// Constructor for <see cref="Create"/>
    /// </summary>
    [JsonConstructor]
    public Create(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Create"/>
    /// </summary>
    public Create(ICoreType context) : base(context)
    {
    }
}
