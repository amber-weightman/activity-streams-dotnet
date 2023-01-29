using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Types;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ActivityStreams.Core.Models;

/// <inheritdoc cref="IStreamsLink" />
public record StreamsLink : CoreTypeBase, IStreamsLink
{
    /// <summary>
    /// Constructor for <see cref="StreamsLink"/>
    /// </summary>
    public StreamsLink(){ }

    /// <summary>
    /// Constructor for <see cref="StreamsLink"/>
    /// </summary>
    public StreamsLink(Uri uri)
    {
        Href = uri;
    }

    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Link) };

    /// <inheritdoc cref="IStreamsLink.Href" />
    public Uri? Href { get; init; }

    /// <inheritdoc cref="IStreamsLink.Rel" />
    public string[]? Rel { get; init; }

    /// <inheritdoc cref="IStreamsLink.HrefLang" />
    [JsonPropertyName("hreflang")]
    public string? HrefLang { get; init; }

    /// <inheritdoc cref="IStreamsLink.Height" />
    [Range(0, int.MaxValue)]
    public int? Height { get; init; }

    /// <inheritdoc cref="IStreamsLink.Width" />
    [Range(0, int.MaxValue)]
    public int? Width { get; init; }
}