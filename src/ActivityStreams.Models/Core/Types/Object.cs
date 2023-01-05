using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
using Newtonsoft.Json;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="IObject" />
public record Object : CoreTypeBase, IObject, ICoreType
{
    public virtual new ObjectType? Type { get; init; } = ObjectType.Object;

    public Uri? Id { get; init; }

    public string? Attachment { get; init; }
    public string? AttributedTo { get; init; }
    public string? Audience { get; init; }
    public string? Content { get; init; }

    public string? Name { get; init; }
    public string? EndTime { get; init; }
    public string? Generator { get; init; }
    public string? Icon { get; init; }
    public string? Image { get; init; }
    public string? InReplyTo { get; init; }
    public string? Location { get; init; }
    public string? Preview { get; init; }
    public string? Published { get; init; }
    public string? Replies { get; init; }
    public string? StartTime { get; init; }
    public string? Summary { get; init; }
    public string? Tag { get; init; }
    public string? Updated { get; init; }
    public Uri? Url { get; init; }
    public string? To { get; init; }
    public string? Bto { get; init; }
    public string? Cc { get; init; }
    public string? Bcc { get; init; }
    public string? MediaType { get; init; }
    public string? Duration { get; init; }

}