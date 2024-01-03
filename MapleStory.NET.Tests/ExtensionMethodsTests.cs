namespace MapleStory.NET.Tests;

public class ExtensionMethodsTests
{
    [Fact]
    public void ToLogString_ReturnsExpectedLogString_ForSingleException()
    {
        var exception = new Exception("Test Exception");
        var logString = exception.ToLogString();
        var expectedLogString = $"Exception - Test Exception{Environment.NewLine}{Environment.NewLine}{exception.StackTrace}";
        Assert.Equal(expectedLogString, logString);
    }

    [Fact]
    public void ToLogString_ReturnsExpectedLogString_ForNestedExceptions()
    {
        var innerException = new Exception("Inner Exception");
        var outerException = new Exception("Outer Exception", innerException);
        var logString = outerException.ToLogString();
        var expectedLogString = $"Exception - Outer Exception{Environment.NewLine}{outerException.StackTrace}" +
            $"{Environment.NewLine}  Exception - Inner Exception{Environment.NewLine}  {Environment.NewLine}{innerException.StackTrace}";
        Assert.Equal(expectedLogString, logString);
    }

    [Fact]
    public void ToLogString_ReturnsEmptyString_ForNullException()
    {
        Exception? exception = null;
        var logString = exception.ToLogString();
        Assert.Equal(string.Empty, logString);
    }
}
