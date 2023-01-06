using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="ILink" />
public record Link : CoreTypeBase, ILink, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="Link"/>
    /// </summary>
    public Link(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Link"/>
    /// </summary>
    public Link(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="ILink.Type" />
    public virtual new LinkType[]? Type { get; init; } = new[] { LinkType.Link };

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