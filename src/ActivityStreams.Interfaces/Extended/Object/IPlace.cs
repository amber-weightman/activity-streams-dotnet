using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// Represents a logical or physical location. See 
/// <a href="https://www.w3.org/TR/activitystreams-vocabulary/#places">5.3 Representing Places</a> for additional information.
/// <a href="https://www.w3.org/ns/activitystreams#Place">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Place",
///   "name": "Work"
/// }
/// </code>
/// </example>
public interface IPlace : IObject
{
    /// <summary>
    /// Indicates the accuracy of position coordinates on a Place objects. 
    /// Expressed in properties of percentage. e.g. "94.0" means "94.0% accurate".
    /// Valid range is between 0.0f and 100.0f.
    /// <a href="https://www.w3.org/ns/activitystreams#accuracy">See w3.org for further details.</a>
    /// </summary>
    float? Accuracy { get; }

    /// <summary>
    /// Indicates the altitude of a place. The measurement units is indicated using the 
    /// units property. If units is not specified, the default is assumed to be "m" indicating meters.
    /// <a href="https://www.w3.org/ns/activitystreams#altitude">See w3.org for further details.</a>
    /// </summary>
    float? Altitude { get; }

    /// <summary>
    /// The latitude of a place
    /// <a href="https://www.w3.org/ns/activitystreams#latitude">See w3.org for further details.</a>
    /// </summary>
    float? Latitude { get; }

    /// <summary>
    /// The longitude of a place
    /// <a href="https://www.w3.org/ns/activitystreams#longitude">See w3.org for further details.</a>
    /// </summary>
    float? Longitude { get; }

    /// <summary>
    /// The radius from the given latitude and longitude for a Place. 
    /// The units is expressed by the <c>units</c> property. If <c>units</c> is not specified, the default is 
    /// assumed to be "m" indicating "meters".
    /// <a href="https://www.w3.org/ns/activitystreams#radius">See w3.org for further details.</a>
    /// </summary>
    float? Radius { get; } // TODO >= 0

    /// <summary>
    /// Specifies the measurement units for the <c>radius</c> and <c>altitude</c> properties on a <c>Place</c> object (here implemented as <see cref="IPlace"/>). 
    /// If not specified, the default is assumed to be "m" for "meters".
    /// <a href="https://www.w3.org/ns/activitystreams#units">See w3.org for further details.</a>
    /// </summary>
    string? Units { get; } // TODO "cm" | " feet" | " inches" | " km" | " m" | " miles" | xsd:anyURI
}
