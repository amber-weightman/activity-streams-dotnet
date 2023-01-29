using ActivityStreams.Core.Activity.Interfaces;

namespace ActivityStreams.Extended.Activity.Interfaces;

/// <summary>
/// An <c>IntransitiveActivity</c> (here implemented as <see cref="IIntrasitiveActivity"/>) that indicates that the <c>actor</c> has 
/// arrived at the <c>location</c>. The <c>origin</c> can be used to identify 
/// the context from which the <c>actor</c> originated. The <c>target</c> 
/// typically has no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Arrive">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally arrived at work",
///   "type": "Arrive",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "location": {
///     "type": "Place",
///     "name": "Work"
///   },
///   "origin": {
///     "type": "Place",
///     "name": "Home"
///   }
/// }
/// </code>
/// </example>
public interface IArrive : IIntrasitiveActivity
{
}
