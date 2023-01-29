using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Extended.Object.Interfaces;

/// <summary>
/// Represents any kind of multi-paragraph written work.
/// <a href="https://www.w3.org/ns/activitystreams#Article">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Article",
///   "name": "What a Crazy Day I Had",
///   "content": "<div>... you will never believe ...</div>",
///   "attributedTo": "http://sally.example.org"
/// }
/// </code>
/// </example>
public interface IArticle : IStreamsObject
{
}
