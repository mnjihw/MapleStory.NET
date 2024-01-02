using MapleStory.NET.Objects;
using MapleStory.NET.Objects.RankingModels.AchievementRanking;
using MapleStory.NET.Objects.RankingModels.DojangRanking;
using MapleStory.NET.Objects.RankingModels.GuildRanking;
using MapleStory.NET.Objects.RankingModels.OverallRanking;
using MapleStory.NET.Objects.RankingModels.TheSeedRanking;
using MapleStory.NET.Objects.RankingModels.UnionRanking;

namespace MapleStory.NET.Interfaces.Api;
public interface IRankingApi
{
    Task<CallResult<OverallRanking>> GetOverallRankingAsync(string? worldName = null, byte worldType = 0, string? @class = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<OverallRanking>> GetOverallRankingAsync(DateOnly date, string? worldName = null, byte worldType = 0, string? @class = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<UnionRanking>> GetUnionRankingAsync(string? worldName = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<UnionRanking>> GetUnionRankingAsync(DateOnly date, string? worldName = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<GuildRanking>> GetGuildRankingAsync(byte rankingType, string? worldName = null, string? guildName = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<GuildRanking>> GetGuildRankingAsync(DateOnly date, byte rankingType, string? worldName = null, string? guildName = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<DojangRanking>> GetDojangRankingAsync(byte difficulty, string? worldName = null, string? @class = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<DojangRanking>> GetDojangRankingAsync(DateOnly date, byte difficulty, string? worldName = null, string? @class = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(string? worldName = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(DateOnly date, string? worldName = null, string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(string? ocid = null, int page = 1, CancellationToken ct = default);
    Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(DateOnly date, string? ocid = null, int page = 1, CancellationToken ct = default);
}