using System.Collections;
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
            var body = await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            if (httpResponseMessage.IsSuccessStatusCode)
                return new CallResult<T>(JsonSerializer.Deserialize<T>(body, Helper.JsonSerializerOptions));
            else
            {
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(body, Helper.JsonSerializerOptions);
                var error = new ServerError((int)httpResponseMessage.StatusCode, errorResponse?.Error?.Name, errorResponse?.Error?.Message);
                return new CallResult<T>(error);
            }
        }
        catch (HttpRequestException e)
        {
            var exceptionInfo = e.ToLogString();
            return new CallResult<T>(new WebError(exceptionInfo));
        }
        catch (JsonException e)
        {
            var exceptionInfo = e.ToLogString();
            return new CallResult<T>(new DeserializeError(exceptionInfo));
        }
        catch (OperationCanceledException e)
        {
            if (cancellationToken != default && e.CancellationToken == cancellationToken)
                return new CallResult<T>(new CancellationRequestedError());
            else
                return new CallResult<T>(new WebError("Request timed out"));
        }
    }
}