using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IApplication" />
public record Application : Core.Object, IApplication
{
    /// <summary>
    /// Constructor for <see cref="Application"/>
    /// </summary>
    [JsonConstructor]
    public Application(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Application"/>
    /// </summary>
    public Application(ICoreType context) : base(context)
    {
    }
}
