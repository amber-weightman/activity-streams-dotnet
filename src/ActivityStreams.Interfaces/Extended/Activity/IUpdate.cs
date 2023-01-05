using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has updated the <c>object</c>. Note, 
/// however, that this vocabulary does not define a mechanism 
/// for describing the actual set of modifications made to 
/// <c>object</c>.<br/>
/// The <c>target</c> and <c>origin</c> typically have no defined meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Update">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally updated her note",
///   "type": "Update",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": "http://example.org/notes/1"
/// }
/// </code>
/// </example>
public interface IUpdate : IActivity, IActivityBase, IObject, ICoreType
{
}
