using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IPerson" />
public record Person : Core.Object, IPerson
{
    /// <summary>
    /// Constructor for <see cref="Person"/>
    /// </summary>
    [JsonConstructor]
    public Person(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Person"/>
    /// </summary>
    public Person(ICoreType context) : base(context)
    {
    }
}
