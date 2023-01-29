using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Extended.Object.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Object.Models;

/// <inheritdoc cref="IImage" />
public record Image : Document, IImage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Image) };
}
