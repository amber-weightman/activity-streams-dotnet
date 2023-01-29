﻿using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Extended.Actor.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Actor.Models;

/// <inheritdoc cref="IApplication" />
public record Application : StreamsObject, IApplication
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Application) };
}
