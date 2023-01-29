using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Collection.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Types;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Core.Collection.Models;

/// <inheritdoc cref="IStreamsCollection" />
public record StreamsCollection : StreamsObject, IStreamsCollection
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Collection) };

    /// <inheritdoc cref="IStreamsCollection.TotalItems" />
    [Range(0, int.MaxValue)]
    public int? TotalItems { get; init; }

    /// <inheritdoc cref="IStreamsCollection.Current" />
    public ICoreType? Current { get; init; }

    /// <inheritdoc cref="IStreamsCollection.First" />
    public ICoreType? First { get; init; }

    /// <inheritdoc cref="IStreamsCollection.Last" />
    public ICoreType? Last { get; init; }

    /// <inheritdoc cref="IStreamsCollection.Items" />
    public ICoreType[]? Items { get; init; }
}