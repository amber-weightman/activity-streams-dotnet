using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IIntrasitiveActivity" />
public abstract record IntrasitiveActivity : ActivityBase, IIntrasitiveActivity
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.IntrasitiveActivity };
}