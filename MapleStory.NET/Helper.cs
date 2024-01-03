using System.Text.Encodings.Web;
using System.Text.Json;
using MapleStory.NET.Objects;

namespace MapleStory.NET;

public static class Helper
{
    public static JsonSerializerOptions JsonSerializerOptions { get; } = new()
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
        [ApiErrorCode.Unknown] = "Unknown error",
    };
    private const int KoreaStandardTimeOffset = 9;

    public static void ThrowIfBeforeApiLaunch(DateOnly date, DateOnly apiLaunchDate)
    {
        if (date < apiLaunchDate)
            throw new ArgumentException($"Date must be after {apiLaunchDate:yyyy-MM-dd}");
    }
    public static DateOnly GetLatestApiAvailableDate(TimeSpan apiUpdateTime, int dataAgeInDays, DateTimeOffset utcCurrentTime)
    {
        var kstNow = utcCurrentTime.ToOffset(TimeSpan.FromHours(KoreaStandardTimeOffset));
        var daysToSubtract = kstNow.TimeOfDay >= apiUpdateTime ? dataAgeInDays : dataAgeInDays + 1;

        return DateOnly.FromDateTime(kstNow.AddDays(-daysToSubtract).Date);
    }
    public static string GetApiErrorExplanation(ApiErrorCode apiErrorCode) => ApiErrors[apiErrorCode];
}