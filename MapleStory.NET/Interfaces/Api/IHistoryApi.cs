namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory history-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
public interface IHistoryApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ouid or /maplestory/legacy/ouid
    /// <para>Gets identifier (ouid) of a user based on API key.</para>
    /// </summary>
    /// <param name="isLegacyOuid">Whether to use legacy API.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing User object on success or error on failure.</returns>
    Task<CallResult<User>> GetUserAsync(bool isLegacyOuid = false, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/starforce
    /// <para>Gets Star Force Enhancement results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from December 27, 2023 onwards.</b></para>
    /// <para>It can be retrived up to 5 minutes later.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing StarforceHistory object on success or error on failure.</returns>
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/starforce
    /// <para>Gets Star Force Enhancement results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from December 27, 2023 onwards.</b></para>
    /// <para>It can be retrived up to 5 minutes later.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing StarforceHistory object on success or error on failure.</returns>
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/starforce
    /// <para>Gets Star Force Enhancement results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from December 27, 2023 onwards.</b></para>
    /// <para>It can be retrived up to 5 minutes later.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cursor">Cursor for paging.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing StarforceHistory object on success or error on failure.</returns>
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/cube
    /// <para>Gets Cube usage results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from November 25, 2022 onwards.</b></para>
    /// <para>Updates daily at 4 AM KST with the previous day's data. If before 4 AM KST, returns data from two days prior.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CubeHistory object on success or error on failure.</returns>
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/cube
    /// <para>Gets Cube usage results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from November 25, 2022 onwards.</b></para>
    /// <para>Data is updated daily at 4 AM KST with the previous day's data. If a request is made before 4 AM KST, data from two days prior is returned.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CubeHistory object on success or error on failure.</returns>
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/cube
    /// <para>Gets Cube usage results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from November 25, 2022 onwards.</b></para>
    /// <para>Data is updated daily at 4 AM KST with the previous day's data. If a request is made before 4 AM KST, data from two days prior is returned.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cursor">Cursor for paging.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CubeHistory object on success or error on failure.</returns>
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
}
