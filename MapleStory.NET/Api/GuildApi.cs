using MapleStory.NET.Interfaces.Api;
using MapleStory.NET.Objects;
using MapleStory.NET.Objects.GuildModels.Guild;
using MapleStory.NET.Objects.GuildModels.GuildBasic;
using Microsoft.Extensions.Logging;

namespace MapleStory.NET.Api;

public class GuildApi : BaseApi, IGuildApi
{
    private const string ResourcePath = "/maplestory/v1/guild";
    private const string IdEndpoint = "id";
    private const string BasicEndpoint = "basic";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);
    private static TimeSpan ApiUpdateTime => new(1, 0, 0);
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 1);

    internal GuildApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    public Task<CallResult<Guild>> GetAsync(string guildName, string worldName, CancellationToken ct = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(guildName);
        ArgumentException.ThrowIfNullOrWhiteSpace(worldName);

        var parameters = new Dictionary<string, string>
        {
            ["guild_name"] = guildName,
            ["world_name"] = worldName,
        };
        return GetAsync<Guild>($"{ResourcePath}/{IdEndpoint}", parameters, ct);
    }

    public Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, CancellationToken ct = default) => GetBasicAsync(oguildId, LatestAvailableDate, ct);
    public Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly date, CancellationToken ct = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(oguildId);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);

        var parameters = new Dictionary<string, string>
        {
            ["oguild_id"] = oguildId,
            ["date"] = date.ToString("yyyy-MM-dd"),
        };
        return GetAsync<GuildBasic>($"{ResourcePath}/{BasicEndpoint}", parameters, ct);
    }
}