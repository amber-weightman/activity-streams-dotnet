using ActivityStreams.Contract.Types;
using FluentAssertions;

namespace ActivityStreams.UnitTests.Extensions;

public class TypeExtensionsTests
{
    [Theory]
    [InlineData(ObjectType.Unknown)]
    public void GivenInvalidObjectType_WhenToTypeCalled_ThenThrowsArgumentException(ObjectType input)
    {
        // Act
        Action act = () => Models.Utilities.Extensions.TypeExtensions.ToType(input);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(ObjectType.Object, typeof(Models.Core.Object))]
    [InlineData(ObjectType.Link, typeof(Models.Core.Link))]
    [InlineData(ObjectType.Actor, typeof(Models.Core.Object))]
    [InlineData(ObjectType.IntrasitiveActivity, typeof(Models.Core.Activity.IntrasitiveActivity))]
    public void GivenValidObjectType_WhenToTypeCalled_ThenReturnsExpectedType(ObjectType input, Type expectedOutput)
    {
        // Act
        var sut = Models.Utilities.Extensions.TypeExtensions.ToType(input);

        // Assert
        sut.Should().Be(expectedOutput);
    }
}
