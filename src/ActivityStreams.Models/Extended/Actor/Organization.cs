using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Actor;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Actor;

/// <inheritdoc cref="IOrganization" />
public record Organization : Core.Object, IOrganization
{
    /// <summary>
    /// Constructor for <see cref="Organization"/>
    /// </summary>
    [JsonConstructor]
    public Organization(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Organization"/>
    /// </summary>
    public Organization(ICoreType context) : base(context)
    {
    }
}
