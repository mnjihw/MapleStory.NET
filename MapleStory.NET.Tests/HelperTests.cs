namespace MapleStory.NET.Tests;

public class HelperTests
{
    [Fact]
    public void ThrowIfBeforeApiLaunch_ThrowsArgumentException_WhenDateIsBeforeApiLaunch()
    {
        var testDate = new DateOnly(2024, 1, 1);
        var apiLaunchDate = new DateOnly(2024, 1, 2);
        const string expectedMessagePart = "Date must be after";

        var exception = Assert.Throws<ArgumentException>(() =>
            Helper.ThrowIfBeforeApiLaunch(testDate, apiLaunchDate));

        Assert.Contains(expectedMessagePart, exception.Message);
    }

    [Fact]
    public void ThrowIfBeforeApiLaunch_DoesNotThrow_WhenDateIsAfterApiLaunch()
    {
        var testDate = new DateOnly(2024, 1, 2);
        var apiLaunchDate = new DateOnly(2024, 1, 1);

        var exception = Record.Exception(() =>
            Helper.ThrowIfBeforeApiLaunch(testDate, apiLaunchDate));

        Assert.Null(exception);
    }

    [Fact]
    public void ThrowIfBeforeApiLaunch_DoesNotThrow_WhenDateIsSameAsApiLaunch()
    {
        var testDate = new DateOnly(2024, 1, 1);
        var apiLaunchDate = new DateOnly(2024, 1, 1);

        var exception = Record.Exception(() =>
            Helper.ThrowIfBeforeApiLaunch(testDate, apiLaunchDate));

        Assert.Null(exception);
    }

    [Theory]
    [InlineData("2024-01-01T16:00:00Z", 1, 0, 0, "2024-01-02")]
    [InlineData("2024-01-01T15:00:00Z", 1, 0, 0, "2024-01-01")]
    [InlineData("2024-01-01T15:00:00Z", 0, 0, 0, "2024-01-02")]
    [InlineData("2024-01-01T14:59:59Z", 0, 0, 0, "2024-01-01")]
    [InlineData("2024-01-01T23:30:00Z", 8, 30, 0, "2024-01-02")]
    [InlineData("2024-01-01T22:30:00Z", 8, 30, 0, "2024-01-01")]
    public void GetLatestApiAvailableDate_ReturnsCorrectDate(string utcCurrentTimeString, int apiUpdateTimeHours, int apiUpdateTimeMinutes, int dataAgeInDays, string expectedDateString)
    {
        // Arrange
        DateTimeOffset utcCurrentTime = DateTimeOffset.Parse(utcCurrentTimeString);
        TimeSpan apiUpdateTime = new(apiUpdateTimeHours, apiUpdateTimeMinutes, 0);
        DateOnly expectedDate = DateOnly.Parse(expectedDateString);

        // Act
        DateOnly actualDate = Helper.GetLatestApiAvailableDate(apiUpdateTime, dataAgeInDays, utcCurrentTime);

        // Assert
        Assert.Equal(expectedDate, actualDate);
    }

    [Theory]
    [InlineData(ApiErrorCode.OPENAPI00001, "Internal server error")]
    [InlineData(ApiErrorCode.OPENAPI00002, "Not authorized")]
    [InlineData(ApiErrorCode.OPENAPI00003, "Invalid identifier")]
    [InlineData(ApiErrorCode.OPENAPI00004, "Parameter is missing or invalid")]
    [InlineData(ApiErrorCode.OPENAPI00005, "Invalid API key")]
    [InlineData(ApiErrorCode.OPENAPI01005, "Invalid API key")]
    [InlineData(ApiErrorCode.OPENAPI00006, "Invalid game or API path")]
    [InlineData(ApiErrorCode.OPENAPI00007, "API rate limit exceeded")]
    [InlineData(ApiErrorCode.OPENAPI01007, "API rate limit exceeded")]
    [InlineData(ApiErrorCode.Unknown, "Unknown error")]
    public void GetApiErrorExplanation_ReturnsCorrectExplanation(ApiErrorCode errorCode, string expectedExplanation)
    {
        string actualExplanation = Helper.GetApiErrorExplanation(errorCode);

        Assert.Equal(expectedExplanation, actualExplanation);
    }
}