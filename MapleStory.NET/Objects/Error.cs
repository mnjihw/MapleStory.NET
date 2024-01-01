namespace MapleStory.NET.Objects;

public abstract class Error(int? code, string? apiErrorCode, string? message)
{
    public int? Code { get; set; } = code;
    public string? ApiErrorCode { get; set; } = apiErrorCode;
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
    public ServerError(int code, string? apiErrorCode, string? message) : base(code, apiErrorCode, message) { }
}


public class WebError : Error
{
    public WebError(string message) : base(null, null, message) { }
    public WebError(int code, string message) : base(code, null, message) { }
}

public class DeserializeError(string message) : Error(null, null, message)
{
}

public class CancellationRequestedError : Error
{
    public CancellationRequestedError() : base(null, null, "Cancellation requested") { }
}