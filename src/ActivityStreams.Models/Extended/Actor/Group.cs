using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IGroup" />
public record Group: Core.Object, IGroup
{
    /// <summary>
    /// Constructor for <see cref="Group"/>
    /// </summary>
    [JsonConstructor]
    public Group(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Group"/>
    /// </summary>
    public Group(ICoreType context) : base(context)
    {
    }
}
