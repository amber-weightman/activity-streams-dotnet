using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> is traveling to <c>target</c> from <c>origin</c>. 
/// <c>Travel</c> is an <c>IntransitiveObject</c> (here implemented as <see cref="IIntrasitiveActivity"/>) whose <c>actor</c> specifies the 
/// direct object. If the <c>target</c> or <c>origin</c> are not specified, 
/// either can be determined by context.
/// <a href="https://www.w3.org/ns/activitystreams#Travel">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally went home from work",
///   "type": "Travel",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "target": {
///     "type": "Place",
///     "name": "Home"
///   },
///   "origin": {
///     "type": "Place",
///     "name": "Work"
///   }
/// }
/// </code>
/// </example>
public interface ITravel : IIntrasitiveActivity, IActivityBase, IObject, ICoreType
{
}
