using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IListen" />
public record Listen : Core.Activity.Activity, IListen
{
    /// <summary>
    /// Constructor for <see cref="Listen"/>
    /// </summary>
    [JsonConstructor]
    public Listen(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Listen"/>
    /// </summary>
    public Listen(ICoreType context) : base(context)
    {
    }
}
