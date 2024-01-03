using MapleStory.NET.Objects;
using MapleStory.NET.Objects.GuildModels.Guild;
using MapleStory.NET.Objects.GuildModels.GuildBasic;

namespace MapleStory.NET.Interfaces.Api;
public interface IGuildApi
{
    Task<CallResult<Guild>> GetAsync(string guildName, string worldName, CancellationToken ct = default);
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, CancellationToken ct = default);
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly date, CancellationToken ct = default);
}
