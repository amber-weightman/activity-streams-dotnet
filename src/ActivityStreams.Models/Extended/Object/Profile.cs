using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IProfile" />
public record Profile : Core.Object, IProfile
{
    /// <summary>
    /// Constructor for <see cref="Profile"/>
    /// </summary>
    [JsonConstructor]
    public Profile(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Profile"/>
    /// </summary>
    public Profile(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="IProfile.Describes" />
    public IObject? Describes { get; init; }
}
