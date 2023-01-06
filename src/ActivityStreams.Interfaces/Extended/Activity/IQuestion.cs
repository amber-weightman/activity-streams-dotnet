using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Represents a question being asked. Question objects are an 
/// extension of <c>IntransitiveActivity</c> (here implemented as <see cref="IIntrasitiveActivity"/>). That is, the Question 
/// object is an Activity (here implemented as <see cref="IActivity"/>), but the direct object is the question 
/// itself and therefore it would not contain an <c>object</c> property.<br/>
/// Either of the <c>anyOf</c> and <c>oneOf</c> properties <b>may</b> be used to 
/// express possible answers, but a Question object <b>must not</b>
/// have both properties.
/// <a href="https://www.w3.org/ns/activitystreams#Question">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Question",
///   "name": "What is the answer?",
///   "oneOf": [
///     {
///       "type": "Note",
///       "name": "Option A"
///     },
///     {
///     "type": "Note",
///       "name": "Option B"
///     }
///   ]
/// }
/// </code>
/// </example>
public interface IQuestion : IIntrasitiveActivity, IActivityBase, IObject, ICoreType
{
    /// <summary>
    /// Identifies an exclusive option for a Question. Use of <c>oneOf</c>> implies that the Question can 
    /// have only a single answer. To indicate that a Question can have multiple answers, use 
    /// <c>anyOf</c>.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#oneOf">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? OneOf { get; }

    /// <summary>
    /// Identifies an inclusive option for a Question. Use of <c>anyOf</c> implies that the Question 
    /// can have multiple answers. To indicate that a Question can have only one answer, use 
    /// <c>oneOf</c>.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#anyOf">See w3.org for further details.</a>
    /// </summary>
    ICoreType[]? AnyOf { get; }

    /// <summary>
    /// Indicates that a question has been closed, and answers are no longer accepted.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/> or <c>xsd:dateTime</c> or <c>xsd:boolean</c>.
    /// <a href="https://www.w3.org/ns/activitystreams#closed">See w3.org for further details.</a>
    /// </summary>
    object[]? Closed { get; } // TODO serialiser
}
