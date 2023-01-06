using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="IObject" />
public record Object : CoreTypeBase, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="Object"/>
    /// </summary>
    [JsonConstructor]
    public Object(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Object"/>
    /// </summary>
    public Object(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="IObject.Type" />
    public virtual new ObjectType[]? Type { get; init; } = new[] { ObjectType.Object };

    /// <inheritdoc cref="IObject.Attachment" />
    public ICoreType[]? Attachment { get; init; }

    /// <inheritdoc cref="IObject.Audience" />
    public ICoreType[]? Audience { get; init; }

    /// <inheritdoc cref="IObject.Content" />
    public string[]? Content { get; init; }
    
    /// <inheritdoc cref="IObject.EndTime" />
    public DateTime? EndTime { get; init; }

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
    public DateTime? Published { get; init; }

    /// <inheritdoc cref="IObject.Replies" />
    public ICollection? Replies { get; init; }

    /// <inheritdoc cref="IObject.StartTime" />
    public DateTime? StartTime { get; init; }

    /// <inheritdoc cref="IObject.Summary" />
    public string[]? Summary { get; init; }

    /// <inheritdoc cref="IObject.Tag" />
    public ICoreType[]? Tag { get; init; }

    /// <inheritdoc cref="IObject.Updated" />
    public DateTime? Updated { get; init; }

    /// <inheritdoc cref="IObject.Url" />
    public object[]? Url { get; init; }

    /// <inheritdoc cref="IObject.To" />
    public ICoreType[]? To { get; init; }

    /// <inheritdoc cref="IObject.Bto" />
    public ICoreType[]? Bto { get; init; }

    /// <inheritdoc cref="IObject.Cc" />
    public ICoreType[]? Cc { get; init; }

    /// <inheritdoc cref="IObject.Bcc" />
    public ICoreType[]? Bcc { get; init; }

    /// <inheritdoc cref="IObject.Duration" />
    public string[]? Duration { get; init; }
}