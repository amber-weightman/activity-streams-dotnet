using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// Indicates that the <c>actor</c> has created the <c>object</c>.
/// <a href="https://www.w3.org/ns/activitystreams#Create">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally created a note",
///   "type": "Create",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Note",
///     "name": "A Simple Note",
///     "content": "This is a simple note"
///   }
/// }
/// </code>
/// </example>
public interface ICreate : IActivity
{
}
