using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IIntrasitiveActivity" />
public abstract record IntrasitiveActivity : ActivityBase, IIntrasitiveActivity
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.IntrasitiveActivity) };
}