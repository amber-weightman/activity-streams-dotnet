using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IRelationship" />
public record Relationship : Core.Object, IRelationship
{
    /// <summary>
    /// Constructor for <see cref="InnerRelationship"/>
    /// </summary>
    [JsonConstructor]
    public Relationship(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="InnerRelationship"/>
    /// </summary>
    public Relationship(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="IRelationship.Subject" />
    public ICoreType? Subject { get; init; }

    /// <inheritdoc cref="IRelationship.Object" />
    public ICoreType[]? Object { get; init; }

    /// <inheritdoc cref="IRelationship.InnerRelationship" />
    [JsonPropertyName("relationship")]
    public IObject[]? InnerRelationship { get; init; }
}
