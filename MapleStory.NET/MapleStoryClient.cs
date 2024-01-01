using MapleStory.NET.Api;
using MapleStory.NET.Interfaces.Api;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace MapleStory.NET;
public class MapleStoryClient : IDisposable
{
    public ICharacterApi CharacterApi { get; }
    public IGuildApi GuildApi { get; }
    public IHistoryApi HistoryApi { get; }
    public IRankingApi RankingApi { get; }
    public IUnionApi UnionApi { get; }
    private HttpClient? HttpClient { get; set; }
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

        var loggerName = "MapleStory.NET";
        var logger = loggerFactory?.CreateLogger(loggerName) ?? NullLoggerFactory.Instance.CreateLogger(loggerName);

        CharacterApi = new CharacterApi(logger, HttpClient);
        GuildApi = new GuildApi(logger, HttpClient);
        HistoryApi = new HistoryApi(logger, HttpClient);
        RankingApi = new RankingApi(logger, HttpClient);
        UnionApi = new UnionApi(logger, HttpClient);
    }
    ~MapleStoryClient() => Dispose(false);

    public void Dispose()
    {
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
