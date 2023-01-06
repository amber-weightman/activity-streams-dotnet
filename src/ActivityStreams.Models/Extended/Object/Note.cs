using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="INote" />
public record Note : Core.Object, INote
{
    /// <summary>
    /// Constructor for <see cref="Note"/>
    /// </summary>
    [JsonConstructor]
    public Note(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Note"/>
    /// </summary>
    public Note(ICoreType context) : base(context)
    {
    }
}
