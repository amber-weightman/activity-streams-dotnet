using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Activity.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Types;

namespace ActivityStreams.Core.Activity.Models;

/// <inheritdoc cref="IActivityBase" />
public abstract record ActivityBase : StreamsObject, IActivityBase
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Activity) };

    /// <inheritdoc cref="IActivityBase.Actor" />
    public ICoreType[]? Actor { get; init; }

    /// <inheritdoc cref="IActivityBase.Target" />
    public ICoreType[]? Target { get; init; }

    /// <inheritdoc cref="IActivityBase.Result" />
    public ICoreType[]? Result { get; init; }

    /// <inheritdoc cref="IActivityBase.Origin" />
    public ICoreType[]? Origin { get; init; }

    /// <inheritdoc cref="IActivityBase.Instrument" />
    public ICoreType[]? Instrument { get; init; }
}