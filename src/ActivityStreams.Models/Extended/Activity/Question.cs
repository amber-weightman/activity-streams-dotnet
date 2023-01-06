using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Models.Core.Activity;
using System.Text.Json.Serialization;

namespace ActivityStreams.Models.Extended.Activity;

/// <inheritdoc cref="IQuestion" />
public record Question : IntrasitiveActivity, IQuestion
{
    /// <summary>
    /// Constructor for <see cref="Question"/>
    /// </summary>
    [JsonConstructor]
    public Question(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="Question"/>
    /// </summary>
    public Question(ICoreType context) : base(context)
    {
    }

    /// <inheritdoc cref="IQuestion.OneOf" />
    public ICoreType[]? OneOf { get; init; }

    /// <inheritdoc cref="IQuestion.AnyOf" />
    public ICoreType[]? AnyOf { get; init; }

    /// <inheritdoc cref="IQuestion.Closed" />
    public object[]? Closed { get; init; }
}
