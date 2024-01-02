using MapleStory.NET.Interfaces.Api;
using MapleStory.NET.Objects;
using MapleStory.NET.Objects.HistoryModels.CubeHistory;
using MapleStory.NET.Objects.HistoryModels.StarforceHistory;
using MapleStory.NET.Objects.HistoryModels.User;
using Microsoft.Extensions.Logging;

namespace MapleStory.NET.Api;

public class HistoryApi : BaseApi, IHistoryApi
{
    private const string ResourcePath = "/maplestory/v1/history";
    private const string StarforceEndpoint = "starforce";
    private const string CubeEndpoint = "cube";
    private static TimeSpan StarforceHistoryApiUpdateTime => new(0, 0, 0);
    private static TimeSpan CubeHistoryApiUpdateTime => new(1, 0, 0);
    private static DateOnly StarforceApiLaunchDate => new(2023, 12, 27);
    private static DateOnly CubeApiLaunchDate => new(2022, 11, 25);

    internal HistoryApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    public Task<CallResult<User>> GetUserAsync(bool isLegacyOuid = false, CancellationToken ct = default)
    {
        string endpoint;

        if (isLegacyOuid)
            endpoint = "/maplestory/legacy/ouid";
        else
            endpoint = "/maplestory/v1/ouid";
        return GetAsync<User>(endpoint, [], ct);
    }
    public Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, CancellationToken ct = default) => GetStarforceHistoryAsync(count, GetLatestAvailableDate(StarforceEndpoint), null, ct);
    public Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly date, CancellationToken ct = default) => GetStarforceHistoryAsync(count, date, null, ct);
    public Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, string cursor, CancellationToken ct = default) => GetStarforceHistoryAsync(count, null, cursor, ct);
    private Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly? date, string? cursor, CancellationToken ct = default) => GetAsync<StarforceHistory>(StarforceEndpoint, count, date, cursor, StarforceApiLaunchDate, ct);
    public Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, CancellationToken ct = default) => GetCubeHistoryAsync(count, GetLatestAvailableDate(CubeEndpoint), null, ct);
    public Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly date, CancellationToken ct = default) => GetCubeHistoryAsync(count, date, null, ct);
    public Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, string cursor, CancellationToken ct = default) => GetCubeHistoryAsync(count, null, cursor, ct);
    private Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly? date, string? cursor, CancellationToken ct = default) => GetAsync<CubeHistory>(CubeEndpoint, count, date, cursor, CubeApiLaunchDate, ct);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, int count, DateOnly? date, string? cursor, DateOnly apiLaunchDate, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        if (count < 10 || count > 1000)
            throw new ArgumentException("Count must be between 10 and 1000");
        if (date is not null && cursor is not null)
            throw new ArgumentException("Date and cursor cannot be set at the same time");

        var parameters = new Dictionary<string, string> { ["count"] = count.ToString() };

        if (date is not null)
            Helper.ThrowIfBeforeApiLaunch(date.Value, apiLaunchDate);
        if (date is null && cursor is null)
            date = GetLatestAvailableDate(endpoint);
        if (date is not null)
            parameters["date"] = date.Value.ToString("yyyy-MM-dd");
        else if (cursor is not null)
            parameters["cursor"] = cursor;
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }
    private static DateOnly GetLatestAvailableDate(string endpoint)
    {
        if (endpoint == StarforceEndpoint)
            return Helper.GetLatestApiAvailableDate(StarforceHistoryApiUpdateTime, 0);
        else if (endpoint == CubeEndpoint)
            return Helper.GetLatestApiAvailableDate(CubeHistoryApiUpdateTime, 1);
        else
            throw new ArgumentException("Invalid endpoint");
    }
}