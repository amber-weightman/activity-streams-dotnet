using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IActivity" />
public record Activity : ActivityBase, IActivity, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="Activity"/>
    /// </summary>
    [JsonConstructor]
    public Activity(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Activity"/>
    /// </summary>
    public Activity(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="IActivity.Object" />
    public ICoreType[]? Object { get; init; }
}