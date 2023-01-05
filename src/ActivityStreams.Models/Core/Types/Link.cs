using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="ILink" />
public record Link : CoreTypeBase, ILink, ICoreType
{
    public virtual new LinkType? Type { get; init; } = LinkType.Link;

    public string? Href { get; init; }
    public string? Rel { get; init; }
    public string? MediaType { get; init; }
    public string? Name { get; init; }
    public string? HrefLang { get; init; }
    public string? Height { get; init; }
    public string? Width { get; init; }
    public string? Preview { get; init; }
}