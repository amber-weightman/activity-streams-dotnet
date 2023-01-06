using ActivityStreams.Contract.Core;
using Newtonsoft.Json;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="ICoreType" />
public abstract record CoreTypeBase : ICoreType
{
    [JsonProperty("@context")]
    public string? Context { get; init; }

    public virtual Enum? Type { get; }
}
