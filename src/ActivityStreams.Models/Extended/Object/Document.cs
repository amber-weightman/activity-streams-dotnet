using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IDocument" />
public record Document : Core.Object, IDocument
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Document };
}
