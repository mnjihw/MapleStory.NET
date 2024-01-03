namespace MapleStory.NET.Interfaces.Api;
public interface IMapleStoryClient
{
    ICharacterApi CharacterApi { get; }
    IGuildApi GuildApi { get; }
    IHistoryApi HistoryApi { get; }
    IRankingApi RankingApi { get; }
    IUnionApi UnionApi { get; }
}
