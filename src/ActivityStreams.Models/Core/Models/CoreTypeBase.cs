using ActivityStreams.Common.Interfaces;
using ActivityStreams.Core.Interfaces;
using System.Text.Json.Serialization;

namespace ActivityStreams.Core.Models;

/// <inheritdoc cref="ICoreType" />
public abstract record CoreTypeBase : ICoreType
{
    /// <inheritdoc cref="ICoreType.Id" />
    public Uri? Id { get; init; }

    /// <inheritdoc cref="ICoreType.Context" />
    [JsonPropertyName("@context")]
    public ICoreType[]? Context { get; init; }

    /// <inheritdoc cref="ICoreType.Type" />
    public virtual IAnyUri[]? Type { get; init; }

    /// <inheritdoc cref="ICoreType.AttributedTo" />
    public ICoreType[]? AttributedTo { get; init; }

    /// <inheritdoc cref="ICoreType.Preview" />
    public ICoreType[]? Preview { get; init; }

    /// <inheritdoc cref="ICoreType.Name" />
    public IRdfLangString? Name { get; init; }
    /// <inheritdoc cref="ICoreType.NameMap" />
    public IRdfLangString? NameMap
    {
        get { return Name; }
        init { Name = value; }
    }

    /// <inheritdoc cref="ICoreType.MediaType" />
    public string? MediaType { get; init; } = "text/html";
}
