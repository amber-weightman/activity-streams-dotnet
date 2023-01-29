using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Extended.Object.Interfaces;

/// <summary>
/// Represents a short written work typically less than a 
/// single paragraph in length.
/// <a href="https://www.w3.org/ns/activitystreams#Note">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Note",
///   "name": "A Word of Warning",
///   "content": "Looks like it is going to rain today. Bring an umbrella!"
/// }
/// </code>
/// </example>
public interface INote : IStreamsObject
{
}
