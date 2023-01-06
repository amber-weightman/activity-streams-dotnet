using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IDocument" />
public record Document : Core.Object, IDocument
{
    /// <summary>
    /// Constructor for <see cref="Document"/>
    /// </summary>
    [JsonConstructor]
    public Document(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Document"/>
    /// </summary>
    public Document(ICoreType context) : base(context)
    {
    }
}
