using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="IObject" />
public record Object : CoreTypeBase, IObject
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Object) };

    /// <inheritdoc cref="IObject.Attachment" />
    public ICoreType[]? Attachment { get; init; }

    /// <inheritdoc cref="IObject.Audience" />
    public ICoreType[]? Audience { get; init; }

    /// <inheritdoc cref="IObject.Content" />
    public IRdfLangString? Content { get; init; }
    /// <inheritdoc cref="IObject.ContentMap" />
    public IRdfLangString? ContentMap
    {
        get { return Content; }
        init { Content = value; }
    }

    /// <inheritdoc cref="IObject.EndTime" />
    public DateTimeXsd? EndTime { get; init; }

    /// <inheritdoc cref="IObject.Generator" />
    public ICoreType[]? Generator { get; init; }

    /// <inheritdoc cref="IObject.Icon" />
    public ICoreType[]? Icon { get; init; }

    /// <inheritdoc cref="IObject.Image" />
    public ICoreType[]? Image { get; init; }

    /// <inheritdoc cref="IObject.InReplyTo" />
    public ICoreType[]? InReplyTo { get; init; }

    /// <inheritdoc cref="IObject.Location" />
    public ICoreType[]? Location { get; init; }

    /// <inheritdoc cref="IObject.Published" />
    public DateTimeXsd? Published { get; init; }

    /// <inheritdoc cref="IObject.Replies" />
    public ICollection? Replies { get; init; }

    /// <inheritdoc cref="IObject.StartTime" />
    public DateTimeXsd? StartTime { get; init; }

    /// <inheritdoc cref="IObject.Summary" />
    public IRdfLangString? Summary { get; init; }
    /// <inheritdoc cref="IObject.SummaryMap" />
    public IRdfLangString? SummaryMap
    {
        get { return Summary; }
        init { Summary = value; }
    }

    /// <inheritdoc cref="IObject.Tag" />
    public ICoreType[]? Tag { get; init; }

    /// <inheritdoc cref="IObject.Updated" />
    public DateTimeXsd? Updated { get; init; }

    /// <inheritdoc cref="IObject.Url" />
    public ILink[]? Url { get; init; }

    /// <inheritdoc cref="IObject.To" />
    public ICoreType[]? To { get; init; }

    /// <inheritdoc cref="IObject.Bto" />
    public ICoreType[]? Bto { get; init; }

    /// <inheritdoc cref="IObject.Cc" />
    public ICoreType[]? Cc { get; init; }

    /// <inheritdoc cref="IObject.Bcc" />
    public ICoreType[]? Bcc { get; init; }

    /// <inheritdoc cref="IObject.Duration" />
    public TimeSpan? Duration { get; init; }
}