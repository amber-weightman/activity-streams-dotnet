using ActivityStreams.Types;

namespace ActivityStreams.Common.Interfaces;

/// <summary>
/// Provides the globally unique identifier. An optional 
/// <see cref="ObjectType" /> may also be provided, which can be used for 
/// determining the local <c>Type</c> of the object.
/// </summary>
public interface IAnyUri
{
    /// <summary>
    /// An optional <see cref="ObjectType" />, which can be used for 
    /// determining the local <c>Type</c> of the object.
    /// </summary>
    ObjectType? Type { get; }

    /// <inheritdoc cref="Uri" />
    Uri Href { get; }
}
