using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Extended.Object;

namespace ActivityStreams.Contract.Types;

/// <summary>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#object-types">w3.org</a>.
/// </summary>
public enum ObjectType
{
    /// <summary>
    /// Identifies an unknown or invalid type
    /// </summary>
    Unknown,

    #region Object

    /// <summary>
    /// Identifies an <c>object</c> of general type <see cref="IObject"/>
    /// </summary>
    Object,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IArticle"/>
    /// </summary>
    Article,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IAudio"/>
    /// </summary>
    Audio,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IDocument"/>
    /// </summary>
    Document,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IEvent"/>
    /// </summary>
    Event,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IImage"/>
    /// </summary>
    Image,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="INote"/>
    /// </summary>
    Note,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IPage"/>
    /// </summary>
    Page,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IPlace"/>
    /// </summary>
    Place,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IProfile"/>
    /// </summary>
    Profile,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IRelationship"/>
    /// </summary>
    Relationship,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="ITombstone"/>
    /// </summary>
    Tombstone,
    /// <summary>
    /// Identifies an <c>object</c> of type <see cref="IVideo"/>
    /// </summary>
    Video,

    #endregion

    #region Collection

    /// <summary>
    /// Identifies a <c>collection</c> of general type <see cref="ICollection"/>
    /// </summary>
    Collection,
    /// <summary>
    /// Identifies a <c>collection</c> of type <see cref="ICollectionPage"/>
    /// </summary>
    CollectionPage,
    /// <summary>
    /// Identifies a <c>collection</c> of type <see cref="IOrderedCollection"/>
    /// </summary>
    OrderedCollection,
    /// <summary>
    /// Identifies a <c>collection</c> of type <see cref="IOrderedCollectionPage"/>
    /// </summary>
    OrderedCollectionPage,

    #endregion

    #region Link

    /// <summary>
    /// Identifies a <c>link</c> of general type <see cref="ILink"/>
    /// </summary>
    Link,
    /// <summary>
    /// Identifies a <c>link</c> of type <see cref="IMention"/>
    /// </summary>
    Mention,

    #endregion

    #region Actor

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
    Service,

    #endregion

    #region Activity

    /// <summary>
    /// Identifies an <c>activity</c> of general type <see cref="IActivity"/>
    /// </summary>
    Activity,
    /// <summary>
    /// Identifies an <c>activity</c> of general type <see cref="IIntrasitiveActivity"/>
    /// </summary>
    IntrasitiveActivity,
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

    #endregion
}
