using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Actor;

/// <summary>
/// Represents an organization.
/// <a href="https://www.w3.org/ns/activitystreams#Organization">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Organization",
///   "name": "Example Co."
/// }
/// </code>
/// </example>
public interface IOrganization : IObject, ICoreType
{
}
