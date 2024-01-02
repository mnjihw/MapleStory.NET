using System.Text.Encodings.Web;
using System.Text.Json;
using MapleStory.NET.Objects;

namespace MapleStory.NET;

public static class Helper
{
    private static Dictionary<ApiErrorCode, string> ApiErrors { get; } = new()
    {
        [ApiErrorCode.OPENAPI00001] = "서버 내부 오류",
        [ApiErrorCode.OPENAPI00002] = "권한 없음",
        [ApiErrorCode.OPENAPI00003] = "유효하지 않은 식별자",
        [ApiErrorCode.OPENAPI00004] = "파라미터가 누락됐거나 유효하지 않음",
        [ApiErrorCode.OPENAPI00005] = "API Key 유효하지 않음",
        [ApiErrorCode.OPENAPI01005] = "API Key 유효하지 않음",
        [ApiErrorCode.OPENAPI00006] = "게임 또는 API Path가 유효하지 않음",
        [ApiErrorCode.OPENAPI00007] = "API 호출량 초과",
        [ApiErrorCode.OPENAPI01007] = "API 호출량 초과",
        [ApiErrorCode.Unknown] = "알 수 없는 에러",
    };
    public static JsonSerializerOptions JsonSerializerOptions { get; } = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        WriteIndented = true,
        AllowTrailingCommas = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };
    private const int KoreaStandardTimeOffset = 9;

    public static void ThrowIfBeforeApiLaunch(DateOnly date, DateOnly apiLaunchDate)
    {
        if (date < apiLaunchDate)
            throw new ArgumentException($"Date must be after {apiLaunchDate:yyyy-MM-dd}");
    }
    public static DateOnly GetLatestApiAvailableDate(TimeSpan apiUpdateTime, int dataAgeInDays)
    {
        var kstNow = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(KoreaStandardTimeOffset));
        var daysToSubtract = kstNow.TimeOfDay > apiUpdateTime ? dataAgeInDays : dataAgeInDays + 1;

        return DateOnly.FromDateTime(kstNow.AddDays(-daysToSubtract).Date);
    }
    public static string GetApiErrorExplanation(ApiErrorCode apiErrorCode) => ApiErrors[apiErrorCode];
}