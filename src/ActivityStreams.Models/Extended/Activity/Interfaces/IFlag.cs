using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// Indicates that the <c>actor</c> is "flagging" the <c>object</c>. 
/// Flagging is defined in the sense common to many social 
/// platforms as reporting content as being inappropriate 
/// for any number of reasons.
/// <a href="https://www.w3.org/ns/activitystreams#Flag">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally flagged an inappropriate note",
///   "type": "Flag",
///   "actor": "http://sally.example.org",
///   "object": {
///     "type": "Note",
///     "content": "An inappropriate note"
///   }
/// }
/// </code>
/// </example>
public interface IFlag : IActivity
{
}
