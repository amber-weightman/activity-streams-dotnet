using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="ILink" />
public record Link : CoreTypeBase, ILink, ICoreType
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Link };

    /// <inheritdoc cref="ILink.Href" />
    public Uri? Href { get; init; }

    /// <inheritdoc cref="ILink.Rel" />
    public string[]? Rel { get; init; }

    /// <inheritdoc cref="ILink.HrefLang" />
    public string? HrefLang { get; init; }

    /// <inheritdoc cref="ILink.Height" />
    public int? Height { get; init; }

    /// <inheritdoc cref="ILink.Width" />
    public int? Width { get; init; }
}