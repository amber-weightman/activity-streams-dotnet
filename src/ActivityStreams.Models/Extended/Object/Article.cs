using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IArticle" />
public record Article : Core.Object, IArticle
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Article };
}
