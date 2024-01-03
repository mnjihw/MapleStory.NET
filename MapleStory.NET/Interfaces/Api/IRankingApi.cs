namespace MapleStory.NET.Interfaces.Api;
public interface IRankingApi
{
    Task<CallResult<OverallRanking>> GetOverallRankingAsync(string? worldName = null, byte worldType = 0, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<OverallRanking>> GetOverallRankingAsync(DateOnly date, string? worldName = null, byte worldType = 0, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<UnionRanking>> GetUnionRankingAsync(string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<UnionRanking>> GetUnionRankingAsync(DateOnly date, string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<GuildRanking>> GetGuildRankingAsync(byte rankingType, string? worldName = null, string? guildName = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<GuildRanking>> GetGuildRankingAsync(DateOnly date, byte rankingType, string? worldName = null, string? guildName = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<DojangRanking>> GetDojangRankingAsync(byte difficulty, string? worldName = null, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<DojangRanking>> GetDojangRankingAsync(DateOnly date, byte difficulty, string? worldName = null, string? @class = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(DateOnly date, string? worldName = null, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(DateOnly date, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
}