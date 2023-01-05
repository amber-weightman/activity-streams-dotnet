﻿using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Actor;

/// <summary>
/// Describes a software application.
/// <a href="https://www.w3.org/ns/activitystreams#Application">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Application",
///   "name": "Exampletron 3000"
/// }
/// </code>
/// </example>
public interface IApplication : IObject, ICoreType
{
}
