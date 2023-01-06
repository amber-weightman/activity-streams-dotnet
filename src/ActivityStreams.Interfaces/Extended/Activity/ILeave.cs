﻿using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Activity;

/// <summary>
/// Indicates that the <c>actor</c> has left the <c>object</c>. The <c>target</c> 
/// and <c>origin</c> typically have no meaning.
/// <a href="https://www.w3.org/ns/activitystreams#Leave">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "summary": "Sally left work",
///   "type": "Leave",
///   "actor": {
///     "type": "Person",
///     "name": "Sally"
///   },
///   "object": {
///     "type": "Place",
///     "name": "Work"
///   }
/// }
/// </code>
/// </example>
public interface ILeave : IActivity, IActivityBase, IObject, ICoreType
{
}
