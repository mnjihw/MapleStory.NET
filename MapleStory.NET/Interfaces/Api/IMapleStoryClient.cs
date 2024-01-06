namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// Wrapper client for MapleStory API.
/// </summary>
public interface IMapleStoryClient
{
    /// <inheritdoc />
    ICharacterApi CharacterApi { get; }
    /// <inheritdoc />
    IGuildApi GuildApi { get; }
    /// <inheritdoc />
    IHistoryApi HistoryApi { get; }
    /// <inheritdoc />
    IRankingApi RankingApi { get; }
    /// <inheritdoc />
    IUnionApi UnionApi { get; }
}
