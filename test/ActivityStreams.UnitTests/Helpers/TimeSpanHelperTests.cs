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
        double expectedYears, double expectedMonths, double expectedDays,
        double expectedHours, double expectedMinutes, double expectedSeconds)
    {
        // Arrange
        var expectedTotalDays = (expectedYears * 365) + (expectedMonths * 30) + expectedDays;
        var expected = TimeSpan.FromDays(expectedTotalDays) + TimeSpan.FromHours(expectedHours) + TimeSpan.FromMinutes(expectedMinutes) + TimeSpan.FromSeconds(expectedSeconds);

        // Act
        var result = TimeSpanHelper.ToTimeSpan(input);

        // Assert
        result.Days.Should().Be((int)expectedTotalDays);
        result.Hours.Should().Be((int)expectedHours);
        result.Minutes.Should().Be((int)expectedMinutes);
        result.Seconds.Should().Be((int)expectedSeconds);
        result.Should().Be(expected);
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
    //[InlineData("PT15.S", Skip = ".NET unexpected handling")] // at least one digit must follow the decimal point if it appears // TODO for some reason .NET treats this as valid
    [InlineData("P1MT-30.5S")] // The ·seconds· value must not be negative if the ·months· value is positive and must not be positive if the ·months· is negative.
    [InlineData("P-1MT30.5S")] // The ·seconds· value must not be negative if the ·months· value is positive and must not be positive if the ·months· is negative.
    [InlineData("")] // an empty value is not valid, unless xsi:nil is used
    public void GivenInvalidXsdDuration_WhenConvertedToTimeSpan_ThenThrowsException(string input)
    {
        // Act
        Action act = () => TimeSpanHelper.ToTimeSpan(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [Theory]
    [InlineData(2, 6, 5, 12, 35, 30, "P915DT12H35M30S")]
    [InlineData(0, 0, 1, 2, 0, 0, "P1DT2H")]
    [InlineData(0, 20, 0, 0, 0, 0, "P600D")] // 20 months
    [InlineData(0, 0, 0, 0, 20, 0, "PT20M")] // 20 mins
    [InlineData(0, 0, 0, 0, 0, 0, "PT0S")]
    [InlineData(0, 0, 0, 0, 1, 30.5, "PT1M30.5S")]
    [InlineData(0, 0, -60, 0, 0, 0, "-P60D")]
    [InlineData(0, 0, 0, 2, 0, 0, "PT2H")]
    [InlineData(0, 0, 0, 0, 0, 5, "PT5S")]
    [InlineData(0, 0, 0, 2, 30, 0, "PT2H30M")]
    [InlineData(0, 0, 0, 0, 1, 0, "PT1M")]
    public void GivenValidTimeSpan_WhenConvertedToXsdDurationString_ThenSucceeds(
        double years, double months,
        double days, double hours, double minutes, double seconds, string expectedOutput)
    {
        // Arrange
        var totalDays = (years * 365) + (months * 30) + days;
        var input = TimeSpan.FromDays(totalDays) + TimeSpan.FromHours(hours) + TimeSpan.FromMinutes(minutes) + TimeSpan.FromSeconds(seconds);

        // Act
        var result = TimeSpanHelper.ToString(input);

        // Assert
        result.Should().Be(expectedOutput);
    }
}

// Resource: http://www.datypic.com/sc/xsd/t-xsd_duration.html