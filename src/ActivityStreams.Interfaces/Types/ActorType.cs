using ActivityStreams.Contract.Extended.Actor;

namespace ActivityStreams.Contract.Types;

/// <summary>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#actor-types">w3.org</a>.
/// </summary>
public enum ActorType
{
    /// <summary>
    /// Identifies an <c>actor</c> of unknown type
    /// </summary>
    Actor,
    /// <summary>
    /// Identifies an <c>actor</c> of type <see cref="IApplication"/>
    /// </summary>
    Application,
    /// <summary>
    /// Identifies an <c>actor</c> of type <see cref="IGroup"/>
    /// </summary>
    Group,
    /// <summary>
    /// Identifies an <c>actor</c> of type <see cref="IOrganization"/>
    /// </summary>
    Organization,
    /// <summary>
    /// Identifies an <c>actor</c> of type <see cref="IPerson"/>
    /// </summary>
    Person,
    /// <summary>
    /// Identifies an <c>actor</c> of type <see cref="IService"/>
    /// </summary>
    Service
}
