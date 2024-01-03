using MapleStory.NET.Objects;
using MapleStory.NET.Objects.HistoryModels.CubeHistory;
using MapleStory.NET.Objects.HistoryModels.StarforceHistory;
using MapleStory.NET.Objects.HistoryModels.User;

namespace MapleStory.NET.Interfaces.Api;
public interface IHistoryApi
{
    Task<CallResult<User>> GetUserAsync(bool isLegacyOuid = false, CancellationToken ct = default);
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, CancellationToken ct = default);
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly date, CancellationToken ct = default);
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, string cursor, CancellationToken ct = default);
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, CancellationToken ct = default);
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly date, CancellationToken ct = default);
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, string cursor, CancellationToken ct = default);
}
