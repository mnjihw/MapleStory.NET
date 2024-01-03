using MapleStory.NET.Interfaces.Api;
using MapleStory.NET.Objects;
using MapleStory.NET.Objects.UnionModels.Union;
using MapleStory.NET.Objects.UnionModels.UnionRaider;
using Microsoft.Extensions.Logging;

namespace MapleStory.NET.Api;

public class UnionApi : BaseApi, IUnionApi
{
    private const string ResourcePath = "/maplestory/v1/user";
    private const string UnionEndpoint = "union";
    private const string UnionRaiderEndpoint = "union-raider";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);
    private static TimeSpan ApiUpdateTime => new(1, 0, 0);
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 1, DateTimeOffset.UtcNow);

    internal UnionApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    public Task<CallResult<Union>> GetAsync(string ocid, CancellationToken ct = default) => GetAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<Union>> GetAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<Union>(UnionEndpoint, ocid, date, ct);
    public Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, CancellationToken ct = default) => GetRaiderAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<UnionRaider>(UnionRaiderEndpoint, ocid, date, ct);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, string ocid, DateOnly date, CancellationToken ct) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(ocid);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);

        var parameters = new Dictionary<string, string>
        {
            ["ocid"] = ocid,
            ["date"] = date.ToString("yyyy-MM-dd"),
        };
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, ct);
    }
}