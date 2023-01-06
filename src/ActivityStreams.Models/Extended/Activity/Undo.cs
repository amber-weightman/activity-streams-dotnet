using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IUndo" />
public record Undo : Core.Activity.Activity, IUndo
{
    /// <summary>
    /// Constructor for <see cref="Undo"/>
    /// </summary>
    [JsonConstructor]
    public Undo(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Undo"/>
    /// </summary>
    public Undo(ICoreType context) : base(context)
    {
    }
}
