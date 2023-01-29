namespace ActivityStreams.Extended.Object.Interfaces;

/// <summary>
/// Represents a video document of any kind.
/// <a href="https://www.w3.org/ns/activitystreams#Video">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Video",
///   "name": "Puppy Plays With Ball",
///   "url": "http://example.org/video.mkv",
///   "duration": "PT2H"
/// }
/// </code>
/// </example>
public interface IVideo : IDocument
{
}
