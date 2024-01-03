using MapleStory.NET.Api;
using MapleStory.NET.Interfaces.Api;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace MapleStory.NET;
public class MapleStoryClient : IMapleStoryClient, IDisposable
{
    public ICharacterApi CharacterApi { get; }
    public IGuildApi GuildApi { get; }
    public IHistoryApi HistoryApi { get; }
    public IRankingApi RankingApi { get; }
    public IUnionApi UnionApi { get; }
    protected HttpClient? HttpClient { get; private set; }
    protected ILogger Logger { get; private set; }
    private bool disposed = false;

    public MapleStoryClient(string apiKey, ILoggerFactory? loggerFactory = null) : this(apiKey, TimeSpan.FromSeconds(5), loggerFactory) { }//로거팩토리추가중
    public MapleStoryClient(string apiKey, TimeSpan timeout, ILoggerFactory? loggerFactory = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        HttpClient = new HttpClient
        {
            Timeout = timeout,
            BaseAddress = new Uri(BaseApi.BaseAddress)
        };
        HttpClient.DefaultRequestHeaders.Add("x-nxopen-api-key", apiKey);

        var name = "MapleStory.NET";
        Logger = loggerFactory?.CreateLogger(name) ?? NullLoggerFactory.Instance.CreateLogger(name);
        Logger.LogTrace("{Name}: v{Version}", name, typeof(MapleStoryClient).Assembly.GetName().Version);
        CharacterApi = new CharacterApi(Logger, HttpClient);
        GuildApi = new GuildApi(Logger, HttpClient);
        HistoryApi = new HistoryApi(Logger, HttpClient);
        RankingApi = new RankingApi(Logger, HttpClient);
        UnionApi = new UnionApi(Logger, HttpClient);
    }
    ~MapleStoryClient() => Dispose(false);

    public void Dispose()
    {
        Logger.LogDebug("Disposing client");
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                HttpClient?.Dispose();
                HttpClient = null;
            }
            disposed = true;
        }
    }
}
