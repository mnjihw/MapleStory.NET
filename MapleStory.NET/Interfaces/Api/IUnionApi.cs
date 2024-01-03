namespace MapleStory.NET.Interfaces.Api;
public interface IUnionApi
{
    Task<CallResult<Union>> GetAsync(string ocid, CancellationToken cancellationToken = default);
    Task<CallResult<Union>> GetAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, CancellationToken cancellationToken = default);
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
}