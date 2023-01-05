using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> is blocking the <c>object</c>. Blocking 
/// is a stronger form of <c>Ignore</c> (here implemented as <see cref="IIgnore"/>). The typical use is to support 
/// social systems that allow one user to block activities or 
/// content of other users. The <c>target</c> and <c>origin</c> typically 
/// have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Block">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally blocked Joe",
///   "type": "Block",
///   "actor": "http://sally.example.org",
///   "object": "http://joe.example.org"
/// }
/// </code>
/// </example>
public interface IBlock : IIgnore, IActivity, IActivityBase, IObject, ICoreType
{
}
