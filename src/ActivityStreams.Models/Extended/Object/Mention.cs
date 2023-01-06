using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Core;

namespace ActivityStreams.Models.Extended.Object;

/// <inheritdoc cref="IMention" />
public record Mention : Link, IMention
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override ObjectType[]? Type { get; init; } = new[] { ObjectType.Mention };
}
