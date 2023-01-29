using ActivityStreams.Core.Interfaces;

namespace ActivityStreams.Core.Activity.Interfaces;

/// <summary>
/// An <c>Activity</c> is a subtype of <c>Object</c> (here implemented as <see cref="IStreamsObject"/>) that describes some form of 
/// action that may happen, is currently happening, or has already happened. 
/// The <c>Activity</c> type itself serves as an abstract base type for all types of 
/// activities. It is important to note that the <c>Activity</c> type itself does 
/// not carry any specific semantics about the kind of action being taken.
/// <a href="https://www.w3.org/ns/activitystreams#Activity">See w3.org for further details.</a>
/// </summary>
/// <example>
/// This shows how to increment an integer.
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Activity",
///   "summary": "Sally did something to a note",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Note",
///     "name": "A Note"
///   }
/// }
/// </code>
/// </example>
public interface IActivity : IActivityBase
{
    /// <summary>
    /// When used within an Activity, describes the direct object of the activity. 
    /// For instance, in the activity "John added a movie to his wishlist", the 
    /// object of the activity is the movie added.
    /// Must be either <see cref="IStreamsObject"/> or <see cref="IStreamsLink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#object">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Object { get; }
}