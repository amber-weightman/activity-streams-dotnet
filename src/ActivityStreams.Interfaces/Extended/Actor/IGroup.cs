using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Actor;

/// <summary>
/// Represents a formal or informal collective of Actors.
/// <a href="https://www.w3.org/ns/activitystreams#Group">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Group",
///   "name": "Big Beards of Austin"
/// }
/// </code>
/// </example>
public interface IGroup : IObject
{
}
