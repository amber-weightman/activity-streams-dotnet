using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IProfile" />
public record Profile : Core.Object, IProfile
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Profile) };

    /// <inheritdoc cref="IProfile.Describes" />
    public IObject? Describes { get; init; }
}
