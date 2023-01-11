using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IListen" />
public record Listen : Core.Activity.Activity, IListen
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Listen) };
}
