namespace MapleStory.NET;
public class MapleStoryClient : IMapleStoryClient
{
    /// <inheritdoc />
    public ICharacterApi CharacterApi { get; }
    /// <inheritdoc />
    public IGuildApi GuildApi { get; }
    /// <inheritdoc />
    public IHistoryApi HistoryApi { get; }
    /// <inheritdoc />
    public IRankingApi RankingApi { get; }
    /// <inheritdoc />
    public IUnionApi UnionApi { get; }
    protected ILogger Logger { get; private set; }

    public MapleStoryClient(HttpClient httpClient, string apiKey, ILoggerFactory? loggerFactory = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        httpClient.BaseAddress = new Uri(BaseApi.BaseAddress);
        httpClient.DefaultRequestHeaders.Add("x-nxopen-api-key", apiKey);

        var name = "MapleStory.NET";
        Logger = loggerFactory?.CreateLogger(name) ?? NullLoggerFactory.Instance.CreateLogger(name);
        Logger.LogTrace("{Name}: v{Version}", name, typeof(MapleStoryClient).Assembly.GetName().Version);
        CharacterApi = new CharacterApi(Logger, httpClient);
        GuildApi = new GuildApi(Logger, httpClient);
        HistoryApi = new HistoryApi(Logger, httpClient);
        RankingApi = new RankingApi(Logger, httpClient);
        UnionApi = new UnionApi(Logger, httpClient);
    }
}
