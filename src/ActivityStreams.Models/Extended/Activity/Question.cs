using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using ActivityStreams.Models.Core.Activity;

namespace ActivityStreams.Models.Extended.Activity;

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
