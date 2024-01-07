namespace MapleStory.NET.Api;
/// <inheritdoc />
public class GuildApi : BaseApi, IGuildApi
{
    private const string ResourcePath = "/maplestory/v1/guild";
    private const string IdEndpoint = "id";
    private const string BasicEndpoint = "basic";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);
    private static TimeSpan ApiUpdateTime => new(1, 0, 0);
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 1, DateTimeOffset.UtcNow);

    internal GuildApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    /// <inheritdoc />
    public Task<CallResult<Guild>> GetAsync(string guildName, World world, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(guildName);
        if (world == World.All)
            throw new ArgumentException("A specific World must be set.", nameof(world));

        var parameters = new Dictionary<string, string>
        {
            ["guild_name"] = guildName,
            ["world_name"] = world.ToString(),
        };
        return GetAsync<Guild>($"{ResourcePath}/{IdEndpoint}", parameters, cancellationToken);
    }
    /// <inheritdoc />
    public Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, CancellationToken cancellationToken = default) => GetBasicAsync(oguildId, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(oguildId);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);

        var parameters = new Dictionary<string, string>
        {
            ["oguild_id"] = oguildId,
            ["date"] = date.ToString("yyyy-MM-dd"),
        };
        return GetAsync<GuildBasic>($"{ResourcePath}/{BasicEndpoint}", parameters, cancellationToken);
    }
}