using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="ITombstone" />
public record Tombstone : Core.Object, ITombstone
{
    /// <summary>
    /// Constructor for <see cref="Tombstone"/>
    /// </summary>
    [JsonConstructor]
    public Tombstone(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Tombstone"/>
    /// </summary>
    public Tombstone(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="ITombstone.FormerType" />
    public IObject[]? FormerType { get; init; }

    /// <inheritdoc cref="ITombstone.Deleted" />
    public DateTime? Deleted { get; init; }
}
