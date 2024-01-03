namespace MapleStory.NET.Objects;

public enum ApiErrorCode
{
    OPENAPI00001,
    OPENAPI00002,
    OPENAPI00003,
    OPENAPI00004,
    OPENAPI00005,
    OPENAPI01005,
    OPENAPI00006,
    OPENAPI00007,
    OPENAPI01007,
    Unknown,
}

public abstract class Error(int? code, ApiErrorCode? apiErrorCode, string? message)
{
    public int? Code { get; set; } = code;
    public ApiErrorCode? ApiErrorCode { get; set; } = apiErrorCode;
    public string? Message { get; set; } = message;

    public override string ToString()
    {
        string codePart = Code.HasValue ? $"Code: {Code} " : string.Empty;
        string apiErrorCodePart = ApiErrorCode is not null ? $"*{ApiErrorCode} - " : string.Empty;

        return $"[{GetType().Name}] {codePart}{apiErrorCodePart}{Message}";
    }
}

public class ServerError : Error
{
    public ServerError(string message) : base(null, null, message) { }
    public ServerError(int code, string message) : base(code, null, message) { }
    public ServerError(int code, ApiErrorCode? apiErrorCode, string? message) : base(code, apiErrorCode, message) { }
}


public class WebError : Error
{
    public WebError(string message) : base(null, null, message) { }
    public WebError(int code, string message) : base(code, null, message) { }
}

public class DeserializeError(string message) : Error(null, null, message) { }

public class CancellationRequestedError : Error
{
    public CancellationRequestedError() : base(null, null, "Cancellation requested") { }
}