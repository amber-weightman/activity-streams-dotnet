using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Collection.Interfaces;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Core.Models;

/// <inheritdoc cref="IStreamsObject" />
public record StreamsObject : CoreTypeBase, IStreamsObject
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Object) };

    /// <inheritdoc cref="IStreamsObject.Attachment" />
    public ICoreType[]? Attachment { get; init; }

    /// <inheritdoc cref="IStreamsObject.Audience" />
    public ICoreType[]? Audience { get; init; }

    /// <inheritdoc cref="IStreamsObject.Content" />
    public IRdfLangString? Content { get; init; }
    /// <inheritdoc cref="IStreamsObject.ContentMap" />
    public IRdfLangString? ContentMap
    {
        get { return Content; }
        init { Content = value; }
    }

    /// <inheritdoc cref="IStreamsObject.EndTime" />
    public DateTimeXsd? EndTime { get; init; }

    /// <inheritdoc cref="IStreamsObject.Generator" />
    public ICoreType[]? Generator { get; init; }

    /// <inheritdoc cref="IStreamsObject.Icon" />
    public ICoreType[]? Icon { get; init; }

    /// <inheritdoc cref="IStreamsObject.Image" />
    public ICoreType[]? Image { get; init; }

    /// <inheritdoc cref="IStreamsObject.InReplyTo" />
    public ICoreType[]? InReplyTo { get; init; }

    /// <inheritdoc cref="IStreamsObject.Location" />
    public ICoreType[]? Location { get; init; }

    /// <inheritdoc cref="IStreamsObject.Published" />
    public DateTimeXsd? Published { get; init; }

    /// <inheritdoc cref="IStreamsObject.Replies" />
    public IStreamsCollection? Replies { get; init; }

    /// <inheritdoc cref="IStreamsObject.StartTime" />
    public DateTimeXsd? StartTime { get; init; }

    /// <inheritdoc cref="IStreamsObject.Summary" />
    public IRdfLangString? Summary { get; init; }
    /// <inheritdoc cref="IStreamsObject.SummaryMap" />
    public IRdfLangString? SummaryMap
    {
        get { return Summary; }
        init { Summary = value; }
    }

    /// <inheritdoc cref="IStreamsObject.Tag" />
    public ICoreType[]? Tag { get; init; }

    /// <inheritdoc cref="IStreamsObject.Updated" />
    public DateTimeXsd? Updated { get; init; }

    /// <inheritdoc cref="IStreamsObject.Url" />
    public IStreamsLink[]? Url { get; init; }

    /// <inheritdoc cref="IStreamsObject.To" />
    public ICoreType[]? To { get; init; }

    /// <inheritdoc cref="IStreamsObject.Bto" />
    public ICoreType[]? Bto { get; init; }

    /// <inheritdoc cref="IStreamsObject.Cc" />
    public ICoreType[]? Cc { get; init; }

    /// <inheritdoc cref="IStreamsObject.Bcc" />
    public ICoreType[]? Bcc { get; init; }

    /// <inheritdoc cref="IStreamsObject.Duration" />
    public TimeSpan? Duration { get; init; }
}