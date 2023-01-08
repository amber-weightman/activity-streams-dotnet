using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// Represents a Web Page.
/// <a href="https://www.w3.org/ns/activitystreams#Page">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Page",
///   "name": "Omaha Weather Report",
///   "url": "http://example.org/weather-in-omaha.html"
/// }
/// </code>
/// </example>
public interface IPage : IDocument
{
}
