using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IProfile" />
public record Profile : Core.Object, IProfile
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Profile };

    /// <inheritdoc cref="IProfile.Describes" />
    public IObject? Describes { get; init; }
}
