namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory ranking-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
/// <remarks>
/// All API endpoints provide data only available from December 21, 2023, onwards.
/// Data is updated daily at 1 AM KST with the previous day's data. If a request is made before 1 AM KST, data from two days prior is returned.
/// Be mindful that character's ocid may change with game updates, affecting ocid-based queries.
/// </remarks>
public interface IUnionApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union
    /// <para>Gets union data.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM KST with the previous day's data. If before 1 AM KST, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Union object on success or error on failure.</returns>
    Task<CallResult<Union>> GetAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union
    /// <para>Gets union data.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM KST with the previous day's data. If before 1 AM KST, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Union object on success or error on failure.</returns>
    Task<CallResult<Union>> GetAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union-raider
    /// <para>Gets union raider data.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM KST with the previous day's data. If before 1 AM KST, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionRaider object on success or error on failure.</returns>
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union-raider
    /// <para>Gets union raider data.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM KST with the previous day's data. If before 1 AM KST, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionRaider object on success or error on failure.</returns>
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union-artifact
    /// <para>Gets union artifact data.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM KST with the previous day's data. If before 1 AM KST, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionArtifact object on success or error on failure.</returns>
    Task<CallResult<UnionArtifact>> GetArtifactAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union-artifact
    /// <para>Gets union artifact data.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM KST with the previous day's data. If before 1 AM KST, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionArtifact object on success or error on failure.</returns>
    Task<CallResult<UnionArtifact>> GetArtifactAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
}