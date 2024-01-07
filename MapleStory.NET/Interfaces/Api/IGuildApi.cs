namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory guild-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
/// <remarks>
/// All API endpoints provide data only available from December 21, 2023, onwards.
/// Data is updated daily at 1 AM KST with the previous day's data. If a request is made before 1 AM KST, data from two days prior is returned.
/// Be mindful that character's ocid may change with game updates, affecting ocid-based queries.
/// </remarks>
public interface IGuildApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/id
    /// <para>Gets identifier (oguild_id) of a guild based on its name and the world name it belongs to.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Data is updated daily at 1 AM KST with the previous day's data. If a request is made before 1 AM KST, data from two days prior is returned.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="guildName">Name of a guild.</param>
    /// <param name="world">World the guild belongs to.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Guild object on success or error on failure.</returns>
    Task<CallResult<Guild>> GetAsync(string guildName, World world, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/basic
    /// <para>Gets basic data of a guild based on its oguild_id.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Data is updated daily at 1 AM KST with the previous day's data. If a request is made before 1 AM KST, data from two days prior is returned.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="oguildId">Identifier of a guild.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing GuildBasic object on success or error on failure.</returns>
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/basic
    /// <para>Gets basic data of a guild based on its oguild_id.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Data is updated daily at 1 AM KST with the previous day's data. If a request is made before 1 AM KST, data from two days prior is returned.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="oguildId">Identifier of a guild.</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Guild object on success or error on failure.</returns>
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly date, CancellationToken cancellationToken = default);
}
