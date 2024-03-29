namespace MapleStory.NET.Api;
/// <inheritdoc />
public class UnionApi : BaseApi, IUnionApi
{
    private const string ResourcePath = "/maplestory/v1/user";
    private const string UnionEndpoint = "union";
    private const string UnionRaiderEndpoint = "union-raider";
    private const string UnionArtifactEndpoint = "union-artifact";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);
    private static TimeSpan ApiUpdateTime => new(1, 0, 0);
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 1, DateTimeOffset.UtcNow);

    internal UnionApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    /// <inheritdoc />
    public Task<CallResult<Union>> GetAsync(string ocid, CancellationToken cancellationToken = default) => GetAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<Union>> GetAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<Union>(UnionEndpoint, ocid, date, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, CancellationToken cancellationToken = default) => GetRaiderAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<UnionRaider>(UnionRaiderEndpoint, ocid, date, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<UnionArtifact>> GetArtifactAsync(string ocid, CancellationToken cancellationToken = default) => GetArtifactAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<UnionArtifact>> GetArtifactAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<UnionArtifact>(UnionArtifactEndpoint, ocid, date, cancellationToken);

    private Task<CallResult<T>> GetAsync<T>(string endpoint, string ocid, DateOnly date, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(ocid);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);

        var parameters = new Dictionary<string, string>
        {
            ["ocid"] = ocid,
            ["date"] = date.ToString("yyyy-MM-dd"),
        };
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }
}