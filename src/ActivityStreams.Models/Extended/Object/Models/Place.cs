using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Extended.Object.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Object.Models;

/// <inheritdoc cref="IPlace" />
public record Place : StreamsObject, IPlace
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Place) };

    /// <inheritdoc cref="IPlace.Accuracy" />
    public float? Accuracy { get; init; }

    /// <inheritdoc cref="IPlace.Altitude" />
    public float? Altitude { get; init; }

    /// <inheritdoc cref="IPlace.Latitude" />
    public float? Latitude { get; init; }

    /// <inheritdoc cref="IPlace.Longitude" />
    public float? Longitude { get; init; }

    /// <inheritdoc cref="IPlace.Radius" />
    public float? Radius { get; init; }

    /// <inheritdoc cref="IPlace.Units" />
    public string? Units { get; init; }
}
