using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="ILike" />
public record Like : Core.Activity.Activity, ILike
{
    /// <summary>
    /// Constructor for <see cref="Like"/>
    /// </summary>
    [JsonConstructor]
    public Like(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Like"/>
    /// </summary>
    public Like(ICoreType context) : base(context)
    {
    }
}
