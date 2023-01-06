using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IPlace" />
public record Place : Core.Object, IPlace
{
    /// <summary>
    /// Constructor for <see cref="Place"/>
    /// </summary>
    [JsonConstructor]
    public Place(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Place"/>
    /// </summary>
    public Place(ICoreType context) : base(context)
    {
    }

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
