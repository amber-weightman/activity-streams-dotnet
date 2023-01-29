using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Core.Models;
using ActivityStreams.Extended.Object.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Object.Models;

/// <inheritdoc cref="IArticle" />
public record Article : StreamsObject, IArticle
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Article) };
}
