using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IActivityBase" />
public abstract record ActivityBase : Object, IActivityBase, IObject, ICoreType
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Activity };

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