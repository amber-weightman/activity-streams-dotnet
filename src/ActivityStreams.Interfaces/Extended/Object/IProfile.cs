using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// A Profile is a content object that describes another 
/// Object, typically used to describe <c>Actor Type</c> objects. 
/// The <c>describes</c> property is used to reference the object 
/// being described by the profile.
/// <a href="https://www.w3.org/ns/activitystreams#Profile">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Profile",
///   "summary": "Sally's Profile",
///   "describes": {
///     "type": "Person",
///     "name": "Sally Smith"
///   }
/// }
/// </code>
/// </example>
public interface IProfile : IObject, ICoreType
{
    /// <summary>
    /// On a <c>Profile</c> object, the <c>describes</c> property identifies the object described
    /// by the Profile.
    /// <a href="https://www.w3.org/ns/activitystreams#describes">See w3.org for further details.</a>
    /// </summary>
    IObject? Describes { get; }
}
