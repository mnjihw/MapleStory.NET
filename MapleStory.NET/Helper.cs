using System.Text.Encodings.Web;
using System.Text.Json;

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
}