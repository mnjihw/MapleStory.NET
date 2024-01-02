using MapleStory.NET.Objects;
using MapleStory.NET.Objects.UnionModels.Union;
using MapleStory.NET.Objects.UnionModels.UnionRaider;

namespace MapleStory.NET.Interfaces.Api;
public interface IUnionApi
{
    Task<CallResult<Union>> GetAsync(string ocid, CancellationToken ct = default);
    Task<CallResult<Union>> GetAsync(string ocid, DateOnly date, CancellationToken ct = default);
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, CancellationToken ct = default);
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly date, CancellationToken ct = default);
}