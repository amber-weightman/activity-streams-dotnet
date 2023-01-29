using ActivityStreams.Common.Interfaces;
using ActivityStreams.Common.Models;
using ActivityStreams.Core.Activity.Models;
using ActivityStreams.Core.Interfaces;
using ActivityStreams.Extended.Activity.Interfaces;
using ActivityStreams.Types;

namespace ActivityStreams.Extended.Activity.Models;

/// <inheritdoc cref="IQuestion" />
public record Question : IntrasitiveActivity, IQuestion
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Question) };

    /// <inheritdoc cref="IQuestion.OneOf" />
    public ICoreType[]? OneOf { get; init; }

    /// <inheritdoc cref="IQuestion.AnyOf" />
    public ICoreType[]? AnyOf { get; init; }

    /// <inheritdoc cref="IQuestion.Closed" />
    public object[]? Closed { get; init; }
}
