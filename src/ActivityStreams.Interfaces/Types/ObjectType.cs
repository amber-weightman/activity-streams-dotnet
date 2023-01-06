using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;

namespace ActivityStreams.Contract.Types;

/// <summary>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#object-types">w3.org</a>.
/// </summary>
public enum ObjectType
{
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
    Video
}
