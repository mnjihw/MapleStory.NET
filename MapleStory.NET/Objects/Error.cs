namespace MapleStory.NET.Objects;
/// <summary>
/// API 에러 코드
/// </summary>
public enum ApiErrorCode
{
    /// <summary>
    /// 500 Internal Server Error
    /// </summary>
    OPENAPI00001,
    /// <summary>
    /// 403 Forbidden
    /// </summary>
    OPENAPI00002,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI00003,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI00004,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI00005,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI01005,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI00006,
    /// <summary>
    /// 429 Too Many Requests
    /// </summary>
    OPENAPI00007,
    /// <summary>
    /// 429 Too Many Requests
    /// </summary>
    OPENAPI01007,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI00009,
    /// <summary>
    /// 400 Bad Request
    /// </summary>
    OPENAPI00010,
    /// <summary>
    /// Unknown
    /// </summary>
    Unknown,
}
/// <summary>
/// Error 생성자
/// </summary>
/// <param name="code">일반 에러코드</param>
/// <param name="apiErrorCode">API 에러코드(ServerError에서 사용)</param>
/// <param name="message">에러 메시지</param>
public abstract class Error(int? code, ApiErrorCode? apiErrorCode, string? message)
{
    /// <summary>
    /// 일반 에러코드
    /// </summary>
    public int? Code { get; set; } = code;
    /// <summary>
    /// API 에러코드(ServerError에서 사용)
    /// </summary>
    public ApiErrorCode? ApiErrorCode { get; set; } = apiErrorCode;
    /// <summary>
    /// 에러 메시지
    /// </summary>
    public string? Message { get; set; } = message;
    /// <summary>
    /// 에러 내용을 반환합니다.
    /// </summary>
    /// <returns>에러 내용 문자열</returns>
    public override string ToString()
    {
        string codePart = Code.HasValue ? $"Code: {Code} " : string.Empty;
        string apiErrorCodePart = ApiErrorCode is not null ? $"*{ApiErrorCode} - " : string.Empty;

        return $"[{GetType().Name}] {codePart}{apiErrorCodePart}{Message}";
    }
}

/// <summary>
/// 서버 에러
/// </summary>
public class ServerError : Error
{
    /// <summary>
    /// 서버 에러 생성자
    /// </summary>
    /// <param name="message">에러 메시지</param>
    public ServerError(string message) : base(null, null, message) { }
    /// <summary>
    /// 서버 에러 생성자
    /// </summary>
    /// <param name="code">일반 에러코드</param>
    /// <param name="message">에러 메시지</param>
    public ServerError(int code, string message) : base(code, null, message) { }
    /// <summary>
    /// 서버 에러 생성자
    /// </summary>
    /// <param name="code">일반 에러코드</param>
    /// <param name="apiErrorCode">API 에러코드</param>
    /// <param name="message">에러 메시지</param>
    public ServerError(int code, ApiErrorCode? apiErrorCode, string? message) : base(code, apiErrorCode, message) { }
}

/// <summary>
/// 웹 에러
/// </summary>
public class WebError : Error
{
    /// <summary>
    /// 웹 에러 생성자
    /// </summary>
    /// <param name="message">에러 메시지</param>
    public WebError(string message) : base(null, null, message) { }
    /// <summary>
    /// 웹 에러 생성자
    /// </summary>
    /// <param name="code">일반 에러코드</param>
    /// <param name="message">에러 메시지</param>
    public WebError(int code, string message) : base(code, null, message) { }
}
/// <summary>
/// 역직렬화 에러
/// </summary>
/// <param name="message">에러 메시지</param>
public class DeserializeError(string message) : Error(null, null, message) { }

/// <summary>
/// 취소 요청 에러
/// </summary>
public class CancellationRequestedError : Error
{
    /// <summary>
    /// 취소 요청 에러 생성자
    /// </summary>
    public CancellationRequestedError() : base(null, null, "Cancellation requested") { }
}