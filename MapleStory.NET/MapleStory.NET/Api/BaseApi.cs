using System.Text.Json;
using MapleStory.NET.Objects;
using Microsoft.Extensions.Logging;

namespace MapleStory.NET.Api;
public abstract class BaseApi
{
    protected internal const string BaseAddress = "https://open.api.nexon.com";
    protected ILogger Logger { get; private set; }
    private HttpClient HttpClient { get; set; }

    internal BaseApi(ILogger logger, HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        Logger = logger;
        HttpClient = httpClient;
    }

    protected async Task<CallResult<T>> GetAsync<T>(string endpoint, Dictionary<string, string> parameters, CancellationToken cancellationToken) where T : class
    {
        using var dictFormUrlEncoded = new FormUrlEncodedContent(parameters);
        var queryString = await dictFormUrlEncoded.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        var url = $"{endpoint}?{queryString}";

        try
        {
            var httpResponseMessage = await HttpClient.GetAsync(url, cancellationToken).ConfigureAwait(false);
            Logger.LogInformation("GET {Url} -> {StatusCode}", url, httpResponseMessage.StatusCode);
            var body = await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            if (httpResponseMessage.IsSuccessStatusCode)
                return new CallResult<T>(JsonSerializer.Deserialize<T>(body, Helper.JsonSerializerOptions));
            else
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(body, Helper.JsonSerializerOptions);
                if (!Enum.TryParse(typeof(ApiErrorCode), errorResponse?.Error?.Name, out var apiErrorCode))
                {
                    Logger.LogWarning("Failed to parse ApiErrorCode: {Name}", errorResponse?.Error?.Name);
                    apiErrorCode = ApiErrorCode.Unknown;
                }
                int statusCode = (int)httpResponseMessage.StatusCode;
                var error = new ServerError(statusCode, (ApiErrorCode)apiErrorCode, errorResponse?.Error?.Message);
                Logger.LogError("API Request for {Url} failed with StatusCode: {StatusCode}, ApiErrorCode: {ApiErrorCode}, Message: {Message}", url, statusCode, apiErrorCode, errorResponse?.Error?.Message);
                return new CallResult<T>(error);
            }
        }
        catch (HttpRequestException e)
        {
            var exceptionInfo = e.ToLogString();
            Logger.LogError("HTTP request for {Url} failed: {ExceptionInfo}", url, exceptionInfo);
            return new CallResult<T>(new WebError(exceptionInfo));
        }
        catch (JsonException e)
        {
            var exceptionInfo = e.ToLogString();
            Logger.LogWarning("JSON deserialization for {Url} failed: {ExceptionInfo}", url, exceptionInfo);
            return new CallResult<T>(new DeserializeError(exceptionInfo));
        }
        catch (OperationCanceledException e)
        {
            if (cancellationToken != default && e.CancellationToken == cancellationToken)
            {
                Logger.LogInformation("Operation for {Url} was cancelled by the user.", url);
                return new CallResult<T>(new CancellationRequestedError());
            }
            else
            {
                Logger.LogWarning("The request for {Url} timed out.", url);
                return new CallResult<T>(new WebError("Request timed out"));
            }
        }
    }
}