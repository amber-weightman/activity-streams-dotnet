using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="ILink" />
public record Link : CoreTypeBase, ILink
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Link) };

    /// <inheritdoc cref="ILink.Href" />
    public Uri? Href { get; init; }

    /// <inheritdoc cref="ILink.Rel" />
    public string[]? Rel { get; init; }

    /// <inheritdoc cref="ILink.HrefLang" />
    [JsonPropertyName("hreflang")]
    public string? HrefLang { get; init; }

    /// <inheritdoc cref="ILink.Height" />
    [Range(0, int.MaxValue)]
    public int? Height { get; init; }

    /// <inheritdoc cref="ILink.Width" />
    [Range(0, int.MaxValue)]
    public int? Width { get; init; }
}