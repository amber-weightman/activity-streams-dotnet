using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IActivityBase" />
public abstract record ActivityBase : Object, IActivityBase, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="ActivityBase"/>
    /// </summary>
    [JsonConstructor]
    protected ActivityBase(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="ActivityBase"/>
    /// </summary>
    protected ActivityBase(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="IActivityBase.Type" />
    public virtual new ActivityType[]? Type { get; init; } = new[] { ActivityType.Activity };

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