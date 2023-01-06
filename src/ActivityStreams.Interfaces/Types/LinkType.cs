using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;

namespace ActivityStreams.Contract.Types;

/// <summary>
/// See <a href="https://www.w3.org/TR/activitystreams-vocabulary/#object-types">w3.org</a>.
/// </summary>
public enum LinkType
{
    /// <summary>
    /// Identifies a <c>link</c> of general type <see cref="ILink"/>
    /// </summary>
    Link,
    /// <summary>
    /// Identifies a <c>link</c> of type <see cref="IMention"/>
    /// </summary>
    Mention
}
