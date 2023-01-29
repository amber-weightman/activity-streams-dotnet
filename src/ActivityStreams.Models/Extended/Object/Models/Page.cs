using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Extended.Object.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Object.Models;

/// <inheritdoc cref="IPage" />
public record Page : Document, IPage
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Page) };
}
