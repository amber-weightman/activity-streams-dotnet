using ActivityStreams.Contract.Core;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core;

/// <inheritdoc cref="ICoreType" />
public abstract record CoreTypeBase : ICoreType
{
    /// <summary>
    /// Constructor for <see cref="CoreTypeBase"/>
    /// </summary>
    /// <param name="context"></param>
    public CoreTypeBase(ICoreType[] context)
    {
        Context = context;
    }

    /// <summary>
    /// Constructor for <see cref="CoreTypeBase"/>
    /// </summary>
    /// <param name="context"></param>
    public CoreTypeBase(ICoreType context)
    {
        Context = new[] { context };
    }

    /// <inheritdoc cref="ICoreType.Id" />
    public Uri? Id { get; init; }

    /// <inheritdoc cref="ICoreType.Context" />
    [JsonPropertyName("@context")]
    [Required]
    public ICoreType[] Context { get; init; }

    /// <inheritdoc cref="ICoreType.Type" />
    public virtual Enum[]? Type { get; init; }

    /// <inheritdoc cref="ICoreType.AttributedTo" />
    public ICoreType[]? AttributedTo { get; init; }

    /// <inheritdoc cref="ICoreType.Preview" />
    public ICoreType[]? Preview { get; init; }

    /// <inheritdoc cref="ICoreType.Name" />
    public string[]? Name { get; init; }

    /// <inheritdoc cref="ICoreType.MediaType" />
    public string? MediaType { get; init; }
}
