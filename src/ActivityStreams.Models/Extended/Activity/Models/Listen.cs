using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Extended.Activity.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Activity.Models;

/// <inheritdoc cref="IListen" />
public record Listen : Core.Activity.Models.Activity, IListen
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Listen) };
}
