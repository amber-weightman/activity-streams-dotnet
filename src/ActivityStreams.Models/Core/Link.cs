using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="ILink" />
public record Link : CoreTypeBase, ILink
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
    [Range(0, int.MaxValue)]
    public int? Height { get; init; }

    /// <inheritdoc cref="ILink.Width" />
    [Range(0, int.MaxValue)]
    public int? Width { get; init; }
}