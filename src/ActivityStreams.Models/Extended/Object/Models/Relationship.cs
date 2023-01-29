using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Extended.Object.Interfaces;
using ActivityStreams.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Extended.Object.Models;

/// <inheritdoc cref="IRelationship" />
public record Relationship : StreamsObject, IRelationship
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Relationship) };

    /// <inheritdoc cref="IRelationship.Subject" />
    public ICoreType? Subject { get; init; }

    /// <inheritdoc cref="IRelationship.Object" />
    public ICoreType[]? Object { get; init; }

    /// <inheritdoc cref="IRelationship.InnerRelationship" />
    [JsonPropertyName("relationship")]
    public IStreamsObject[]? InnerRelationship { get; init; }
}
