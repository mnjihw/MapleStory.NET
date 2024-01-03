namespace MapleStory.NET.Interfaces.Api;
public interface IGuildApi
{
    Task<CallResult<Guild>> GetAsync(string guildName, string worldName, CancellationToken cancellationToken = default);
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, CancellationToken cancellationToken = default);
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly date, CancellationToken cancellationToken = default);
}
