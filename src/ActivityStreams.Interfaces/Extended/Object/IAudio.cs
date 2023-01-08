using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// Represents an audio document of any kind.
/// <a href="https://www.w3.org/ns/activitystreams#Audio">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Audio",
///   "name": "Interview With A Famous Technologist",
///   "url": {
///     "type": "Link",
///     "href": "http://example.org/podcast.mp3",
///     "mediaType": "audio/mp3"
///   }
/// }
/// </code>
/// </example>
public interface IAudio : IDocument
{
}
