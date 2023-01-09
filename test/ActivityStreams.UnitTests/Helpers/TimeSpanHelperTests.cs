using ActivityStreams.Models.Utilities.Helpers;
using FluentAssertions;

namespace ActivityStreams.UnitTests.Helpers;

public class TimeSpanHelperTests
{
    [Theory]
    [InlineData("P2Y6M5DT12H35M30S", 2, 6, 5, 12, 35, 30)]
    [InlineData("P1DT2H", 0, 0, 1, 2, 0, 0)]
    [InlineData("P20M", 0, 0, 605, 0, 0, 0)] // 20 months, idk why this would be represented as 605 days
    [InlineData("PT20M", 0, 0, 0, 0, 20, 0)] // 20 mins
    [InlineData("P0Y20M0D", 0, 0, 605, 0, 0, 0)] // 20 months, idk why this would be represented as 605 days
    [InlineData("P0Y", 0, 0, 0, 0, 0, 0)] // 0 years
    [InlineData("PT1M30.5S", 0, 0, 0, 0, 1, 30.5)]
    [InlineData("-P60D", 0, 0, -60, 0, 0, 0)]
    [InlineData("PT2H", 0, 0, 0, 2, 0, 0)]
    [InlineData("PT5S", 0, 0, 0, 0, 0, 5)]
    [InlineData("PT2H30M", 0, 0, 0, 2, 30, 0)]
    [InlineData("PT1M", 0, 0, 0, 0, 1, 0)]
    public void GivenValidXsdDuration_WhenConvertedToTimeSpan_ThenSucceeds(string input,
        int expectedYears, int expectedMonths,
        int expectedDays, int expectedHours, int expectedMinutes, int expectedSeconds)
    {
        // Act
        var result = TimeSpanHelper.ToTimeSpan(input);

        // Assert
        result.Days.Should().Be(expectedDays);
        result.Hours.Should().Be(expectedHours);
        result.Minutes.Should().Be(expectedMinutes);
        result.Seconds.Should().Be(expectedSeconds);
    }

    [Theory]
    [InlineData("P-20M")] // the minus sign must appear first
    [InlineData("P20MT")] // no time items are present, so "T" must not be present
    [InlineData("P1YM5D")] // no value is specified for months, so "M" must not be present
    [InlineData("P15.5Y")] // only the seconds can be expressed as a decimal
    [InlineData("P1D2H")] // "T" must be present to separate days and hours
    [InlineData("1Y2M")] // "P" must always be present
    [InlineData("P2M1Y")] // years must appear before months
    [InlineData("P")] // at least one number and designator are required
    [InlineData("PT15.S")] // at least one digit must follow the decimal point if it appears
    [InlineData("P1MT-30.5S")] // The ·seconds· value must not be negative if the ·months· value is positive and must not be positive if the ·months· is negative.
    [InlineData("P-1MT30.5S")] // The ·seconds· value must not be negative if the ·months· value is positive and must not be positive if the ·months· is negative.
    [InlineData("")] // an empty value is not valid, unless xsi:nil is used
    public async void GivenInvalidXsdDuration_WhenConvertedToTimeSpan_ThenThrowsException(string input)
    {
        // Act
        Func<Task> act = async () => TimeSpanHelper.ToTimeSpan(input);

        // Assert
        await act.Should().ThrowAsync<FormatException>();
    }

    [Theory]
    [InlineData(2, 6, 5, 12, 35, 30, "P2Y6M5DT12H35M30S")]
    [InlineData(0, 0, 1, 2, 0, 0, "P1DT2H")]
    [InlineData(0, 0, 605, 0, 0, 0, "P20M")] // 20 months, idk why this would be represented as 605 days
    [InlineData(0, 0, 0, 0, 20, 0, "PT20M")] // 20 mins
    [InlineData(0, 0, 605, 0, 0, 0, "P0Y20M0D")] // 20 months, idk why this would be represented as 605 days
    [InlineData(0, 0, 0, 0, 0, 0, "P0Y")] // 0 years
    [InlineData(0, 0, 0, 0, 1, 30.5, "PT1M30.5S")]
    [InlineData(0, 0, -60, 0, 0, 0, "-P60D")]
    [InlineData(0, 0, 0, 2, 0, 0, "PT2H")]
    [InlineData(0, 0, 0, 0, 0, 5, "PT5S")]
    [InlineData(0, 0, 0, 2, 30, 0, "PT2H30M")]
    [InlineData(0, 0, 0, 0, 1, 0, "PT1M")]
    public void GivenValidTimeSpan_WhenConvertedToXsdDurationString_ThenSucceeds(
        int years, int months,
        int days, int hours, int minutes, int seconds, string expectedOutput)
    {
        // Arrange
        var input = new TimeSpan(days, hours, minutes, seconds);

        // Act
        var result = TimeSpanHelper.ToString(input);

        // Assert
        result.Should().Be(expectedOutput);
    }
}

// Resource: http://www.datypic.com/sc/xsd/t-xsd_duration.html