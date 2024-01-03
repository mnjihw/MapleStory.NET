namespace MapleStory.NET.Tests;
public class MapleStoryClientTests
{
    [Fact]
    public void Constructor_SetsPropertiesCorrectly()
    {
        var apiKey = "Your_api_key_here";

        using var client = new MapleStoryClient(apiKey);

        Assert.NotNull(client.CharacterApi);
        Assert.NotNull(client.GuildApi);
        Assert.NotNull(client.HistoryApi);
        Assert.NotNull(client.RankingApi);
        Assert.NotNull(client.UnionApi);
    }
}

