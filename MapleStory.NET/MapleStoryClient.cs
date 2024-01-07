namespace MapleStory.NET;
/// <inheritdoc />
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

    /// <summary>
    /// Initializes a new instance of the class with specified HttpClient, API key, and ILoggerFactory.
    /// </summary>
    /// <param name="httpClient">HttpClient instance used throughout the lifecycle</param>
    /// <param name="apiKey">API Key issued by Nexon Open API Center.</param>
    /// <param name="loggerFactory">ILoggerFactory instance used to create a logger for logging.</param>
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
