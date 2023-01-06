using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IPage" />
public record Page : Document, IPage
{
    /// <summary>
    /// Constructor for <see cref="Page"/>
    /// </summary>
    [JsonConstructor]
    public Page(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Page"/>
    /// </summary>
    public Page(ICoreType context) : base(context)
    {
    }
}
