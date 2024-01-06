namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// Endpoints for guild data.
/// </summary>
public interface IGuildApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/id
    /// <para>Gets identifier (oguild_id) of a guild based on its name and the world name it belongs to.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM (KST), returns data from two days prior.</para>
    /// <para>Be mindful that the character's oguild_id may change with game updates, affecting oguild_id-based queries.</para>
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
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM (KST), returns data from two days prior.</para>
    /// <para>Be mindful that the character's oguild_id may change with game updates, affecting oguild_id-based queries.</para>
    /// </summary>
    /// <param name="oguildId">Identifier of a guild.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing GuildBasic object on success or error on failure.</returns>
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/basic
    /// <para>Gets basic data of a guild based on its oguild_id.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM (KST), returns data from two days prior.</para>
    /// <para>Be mindful that the character's oguild_id may change with game updates, affecting oguild_id-based queries.</para>
    /// </summary>
    /// <param name="oguildId">Identifier of a guild.</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Guild object on success or error on failure.</returns>
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly date, CancellationToken cancellationToken = default);
}
