using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Extended.Activity;

namespace ActivityStreams.Contract.Types;

/// <summary>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#activity-types">w3.org</a>.
/// </summary>
public enum ActivityType
{
    /// <summary>
    /// Identifies an <c>activity</c> of general type <see cref="IActivity"/>
    /// </summary>
    Activity,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IAccept"/>
    /// </summary>
    Accept,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IAdd"/>
    /// </summary>
    Add,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IAnnounce"/>
    /// </summary>
    Announce,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IArrive"/>
    /// </summary>
    Arrive,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IBlock"/>
    /// </summary>
    Block,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="ICreate"/>
    /// </summary>
    Create,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IDelete"/>
    /// </summary>
    Delete,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IDislike"/>
    /// </summary>
    Dislike,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IFlag"/>
    /// </summary>
    Flag,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IFollow"/>
    /// </summary>
    Follow,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IIgnore"/>
    /// </summary>
    Ignore,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IInvite"/>
    /// </summary>
    Invite,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IJoin"/>
    /// </summary>
    Join,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="ILeave"/>
    /// </summary>
    Leave,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="ILike"/>
    /// </summary>
    Like,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IListen"/>
    /// </summary>
    Listen,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IMove"/>
    /// </summary>
    Move,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IOffer"/>
    /// </summary>
    Offer,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IQuestion"/>
    /// </summary>
    Question,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IReject"/>
    /// </summary>
    Reject,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IRead"/>
    /// </summary>
    Read,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IRemove"/>
    /// </summary>
    Remove,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="ITentativeReject"/>
    /// </summary>
    TentativeReject,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="ITentativeAccept"/>
    /// </summary>
    TentativeAccept,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="ITravel"/>
    /// </summary>
    Travel,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IUndo"/>
    /// </summary>
    Undo,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IUpdate"/>
    /// </summary>
    Update,
    /// <summary>
    /// Identifies an <c>activity</c> of type <see cref="IView"/>
    /// </summary>
    View
}
