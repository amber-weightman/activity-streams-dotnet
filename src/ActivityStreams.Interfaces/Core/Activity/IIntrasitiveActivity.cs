namespace ActivityStreams.Contract.Core.Activity;

/// <summary>
/// Instances of <c>IntransitiveActivity</c> are a subtype of <c>Activity</c> 
/// (here implemented as <see cref="IActivity"/>)
/// representing intransitive actions. The <c>object</c> property is therefore 
/// inappropriate for these activities.
/// <a href="https://www.w3.org/ns/activitystreams#IntransitiveActivity">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// </code>
/// </example>
public interface IIntrasitiveActivity : IActivityBase
{
}