namespace MapleStory.NET.Interfaces.Api;
public interface IHistoryApi
{
    Task<CallResult<User>> GetUserAsync(bool isLegacyOuid = false, CancellationToken cancellationToken = default);
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, CancellationToken cancellationToken = default);
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, CancellationToken cancellationToken = default);
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
}
