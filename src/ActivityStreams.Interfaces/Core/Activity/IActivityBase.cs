using ActivityStreams.Contract.Types;

namespace ActivityStreams.Contract.Core.Activity;

/// <summary>
/// An <c>Activity</c> is a subtype of <c>Object</c> (here implemented as <see cref="IObject"/>) that describes some form of 
/// action that may happen, is currently happening, or has already happened. 
/// The <c>Activity</c> type itself serves as an abstract base type for all types of 
/// activities. It is important to note that the <c>Activity</c> type itself does 
/// not carry any specific semantics about the kind of action being taken.<br/>
/// <see cref="IActivityBase"/> acts as an abstract base class for <c>Activity</c> implementations 
/// which cannot contain an <c>object</c> property (i.e. <see cref="IIntrasitiveActivity"/>).
/// <a href="https://www.w3.org/ns/activitystreams#Activity">See w3.org for further details.</a>
/// </summary>
public interface IActivityBase : IObject, ICoreType
{
    /// <summary>
    /// Describes one or more entities that either performed or are 
    /// expected to perform the activity. Any single activity can have 
    /// multiple <c>actor</c>s. The <c>actor</c> may be specified using 
    /// an indirect <c>Link</c> (here implemented as <see cref="ILink"/>).
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#actor">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Actor { get; } // TODO not string ObjectLinkSerializer?

    /// <summary>
    /// Describes the indirect object, or target, of the activity. The precise meaning
    /// of the target is largely dependent on the type of action being described but will 
    /// often be the object of the English preposition "to". For instance, in the activity
    /// "John added a movie to his wishlist", the target of the activity is John's wishlist. 
    /// An activity can have more than one target.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#target">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Target { get; }

    /// <summary>
    /// Describes the result of the activity. For instance, if a particular action 
    /// results in the creation of a new resource, the result property can be used to 
    /// describe that new resource.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#result">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Result { get; }

    /// <summary>
    /// Describes an indirect object of the activity from which the activity 
    /// is directed. The precise meaning of the origin is the object of the 
    /// English preposition "from". For instance, in the activity "John 
    /// moved an item to List B from List A", the origin of the activity is
    /// "List A".
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#origin">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Origin { get; }

    /// <summary>
    /// Identifies one or more objects used (or to be used) in the completion of an <c>Activity</c> (here implemented as <see cref="IActivity"/>).
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#instrument">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? Instrument { get; }
}