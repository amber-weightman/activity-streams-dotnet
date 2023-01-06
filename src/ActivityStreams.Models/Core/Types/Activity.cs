using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="IActivityBase" />
public abstract record ActivityBase : Object, IActivityBase, IObject, ICoreType
{
    public virtual new ActivityType? Type { get; init; } = ActivityType.Activity;

    public string? Actor { get; init; }
    public string? Target { get; init; }
    public string? Result { get; init; }
    public string? Origin { get; init; }
    public string? Instrument { get; init; }
}

/// <inheritdoc cref="IActivity" />
public record Activity : ActivityBase, IActivity, IObject, ICoreType
{
    public string? Object { get; init; }
}