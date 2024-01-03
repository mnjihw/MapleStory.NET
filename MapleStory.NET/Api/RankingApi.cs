namespace MapleStory.NET.Api;

public class RankingApi : BaseApi, IRankingApi
{
    private const string ResourcePath = "/maplestory/v1/ranking";
    private const string OverallEndpoint = "overall";
    private const string UnionEndpoint = "union";
    private const string GuildEndpoint = "guild";
    private const string DojangEndpoint = "dojang";
    private const string TheSeedEndpoint = "theseed";
    private const string AchievementEndpoint = "achievement";

    private static DateOnly ApiLaunchDate => new(2023, 12, 22);
    private static TimeSpan ApiUpdateTime => new(8, 30, 0);
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 0, DateTimeOffset.UtcNow);

    internal RankingApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }

    public Task<CallResult<OverallRanking>> GetOverallRankingAsync(string? worldName = null, byte worldType = 0, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetOverallRankingAsync(LatestAvailableDate, worldName, worldType, @class, ocid, page, cancellationToken);
    public Task<CallResult<OverallRanking>> GetOverallRankingAsync(DateOnly date, string? worldName = null, byte worldType = 0, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default)
    {
        Dictionary<string, string> parameters = [];
        if (worldName is null)
            parameters["world_type"] = worldType.ToString();
        if (@class is not null)
            parameters["class"] = @class;
        return GetAsync<OverallRanking>(OverallEndpoint, date, worldName, ocid, page, parameters, cancellationToken);
    }

    public Task<CallResult<UnionRanking>> GetUnionRankingAsync(string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetUnionRankingAsync(LatestAvailableDate, worldName, ocid, page, cancellationToken);
    public Task<CallResult<UnionRanking>> GetUnionRankingAsync(DateOnly date, string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAsync<UnionRanking>(UnionEndpoint, date, worldName, ocid, page, [], cancellationToken);
    public Task<CallResult<GuildRanking>> GetGuildRankingAsync(byte rankingType, string? worldName = null, string? guildName = null, int page = 1, CancellationToken cancellationToken = default) => GetGuildRankingAsync(LatestAvailableDate, rankingType, worldName, guildName, page, cancellationToken);
    public Task<CallResult<GuildRanking>> GetGuildRankingAsync(DateOnly date, byte rankingType, string? worldName = null, string? guildName = null, int page = 1, CancellationToken cancellationToken = default)
    {
        var parameters = new Dictionary<string, string>
        {
            ["ranking_type"] = rankingType.ToString(),
        };
        if (guildName is not null)
            parameters["guild_name"] = guildName;
        return GetAsync<GuildRanking>(GuildEndpoint, date, worldName, null, page, parameters, cancellationToken);
    }

    public Task<CallResult<DojangRanking>> GetDojangRankingAsync(byte difficulty, string? worldName = null, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetDojangRankingAsync(LatestAvailableDate, difficulty, worldName, @class, ocid, page, cancellationToken);
    public Task<CallResult<DojangRanking>> GetDojangRankingAsync(DateOnly date, byte difficulty, string? worldName = null, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default)
    {
        var parameters = new Dictionary<string, string>
        {
            ["difficulty"] = difficulty.ToString(),
        };
        if (@class is not null)
            parameters["class"] = @class;
        return GetAsync<DojangRanking>(DojangEndpoint, date, worldName, ocid, page, parameters, cancellationToken);
    }

    public Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetTheSeedRankingAsync(LatestAvailableDate, worldName, ocid, page, cancellationToken);
    public Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(DateOnly date, string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAsync<TheSeedRanking>(TheSeedEndpoint, date, worldName, ocid, page, [], cancellationToken);
    public Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAchievementRankingAsync(LatestAvailableDate, ocid, page, cancellationToken);
    public Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(DateOnly date, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAsync<AchievementRanking>(AchievementEndpoint, date, null, ocid, page, [], cancellationToken);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, DateOnly date, string? worldName, string? ocid, int page, Dictionary<string, string> parameters, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);
        parameters["date"] = date.ToString("yyyy-MM-dd");

        if (worldName is not null && endpoint != AchievementEndpoint)
            parameters["world_name"] = worldName;
        if (ocid is not null && endpoint != GuildEndpoint)
            parameters["ocid"] = ocid;
        parameters["page"] = page.ToString();
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }

}