using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IService" />
public record Service : Core.Object, IService
{
    /// <summary>
    /// Constructor for <see cref="Service"/>
    /// </summary>
    [JsonConstructor]
    public Service(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Service"/>
    /// </summary>
    public Service(ICoreType context) : base(context)
    {
    }
}
