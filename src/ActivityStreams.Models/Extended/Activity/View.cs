using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IView" />
public record View : Core.Activity.Activity, IView
{
    /// <summary>
    /// Constructor for <see cref="View"/>
    /// </summary>
    [JsonConstructor]
    public View(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="View"/>
    /// </summary>
    public View(ICoreType context) : base(context)
    {
    }
}
