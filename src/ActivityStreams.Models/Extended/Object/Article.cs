using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IArticle" />
public record Article : Core.Object, IArticle
{
    /// <summary>
    /// Constructor for <see cref="Article"/>
    /// </summary>
    [JsonConstructor]
    public Article(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Article"/>
    /// </summary>
    public Article(ICoreType context) : base(context)
    {
    }
}
