using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IRelationship" />
public record Relationship : Core.Object, IRelationship
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Relationship };

    /// <inheritdoc cref="IRelationship.Subject" />
    public ICoreType? Subject { get; init; }

    /// <inheritdoc cref="IRelationship.Object" />
    public ICoreType[]? Object { get; init; }

    /// <inheritdoc cref="IRelationship.InnerRelationship" />
    [JsonPropertyName("relationship")]
    public IObject[]? InnerRelationship { get; init; }
}
