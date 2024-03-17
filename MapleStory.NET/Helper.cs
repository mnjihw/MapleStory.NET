namespace MapleStory.NET;
/// <summary>
/// General helper class.
/// </summary>
public static class Helper
{
    internal static JsonSerializerOptions JsonSerializerOptions { get; } = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        WriteIndented = true,
        AllowTrailingCommas = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };
    private static Dictionary<ApiErrorCode, string> ApiErrors { get; } = new()
    {
        [ApiErrorCode.OPENAPI00001] = "Internal server error",
        [ApiErrorCode.OPENAPI00002] = "Not authorized",
        [ApiErrorCode.OPENAPI00003] = "Invalid identifier",
        [ApiErrorCode.OPENAPI00004] = "Parameter is missing or invalid",
        [ApiErrorCode.OPENAPI00005] = "Invalid API key",
        [ApiErrorCode.OPENAPI01005] = "Invalid API key",
        [ApiErrorCode.OPENAPI00006] = "Invalid game or API path",
        [ApiErrorCode.OPENAPI00007] = "API rate limit exceeded",
        [ApiErrorCode.OPENAPI01007] = "API rate limit exceeded",
        [ApiErrorCode.OPENAPI00009] = "Preparing data",
        [ApiErrorCode.OPENAPI00010] = "Service under maintenance",
        [ApiErrorCode.Unknown] = "Unknown error",
    };
    private const int KoreaStandardTimeOffset = 9;

    internal static void ThrowIfBeforeApiLaunch(DateOnly date, DateOnly apiLaunchDate)
    {
        if (date < apiLaunchDate)
            throw new ArgumentException($"Date must be after {apiLaunchDate:yyyy-MM-dd}");
    }

    internal static DateOnly GetLatestApiAvailableDate(TimeSpan apiUpdateTime, int dataAgeInDays, DateTimeOffset utcCurrentTime)
    {
        var kstNow = utcCurrentTime.ToOffset(TimeSpan.FromHours(KoreaStandardTimeOffset));
        var daysToSubtract = kstNow.TimeOfDay >= apiUpdateTime ? dataAgeInDays : dataAgeInDays + 1;

        return DateOnly.FromDateTime(kstNow.AddDays(-daysToSubtract).Date);
    }
    /// <summary>
    /// Returns the explanation for the given <paramref name="apiErrorCode"/>.
    /// </summary>
    /// <param name="apiErrorCode">Error code returned by the API</param>
    /// <returns></returns>
    public static string GetApiErrorExplanation(ApiErrorCode apiErrorCode) => ApiErrors[apiErrorCode];
}