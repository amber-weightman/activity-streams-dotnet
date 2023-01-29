using ActivityStreams.Core.Activity.Models;
using ActivityStreams.Core.Models;
using ActivityStreams.Types;
using FluentAssertions;
using TypeExtensions = ActivityStreams.Extensions.TypeExtensions;

namespace ActivityStreams.UnitTests.Extensions;

public class TypeExtensionsTests
{
    [Theory]
    [InlineData(ObjectType.Unknown)]
    public void GivenInvalidObjectType_WhenToTypeCalled_ThenThrowsArgumentException(ObjectType input)
    {
        // Act
        Action act = () => TypeExtensions.ToType(input);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(ObjectType.Object, typeof(StreamsObject))]
    [InlineData(ObjectType.Link, typeof(StreamsLink))]
    [InlineData(ObjectType.Actor, typeof(StreamsObject))]
    [InlineData(ObjectType.IntrasitiveActivity, typeof(IntrasitiveActivity))]
    public void GivenValidObjectType_WhenToTypeCalled_ThenReturnsExpectedType(ObjectType input, Type expectedOutput)
    {
        // Act
        var sut = TypeExtensions.ToType(input);

        // Assert
        sut.Should().Be(expectedOutput);
    }
}
