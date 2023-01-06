using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IUndo" />
public record Undo : Core.Activity.Activity, IUndo
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Undo };
}
