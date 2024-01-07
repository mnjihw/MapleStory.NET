namespace MapleStory.NET.Objects;
/// <summary>
/// 에러 응답
/// </summary>
public class ErrorResponse
{
    /// <summary>
    /// 에러 세부정보
    /// </summary>
    public ErrorDetails? Error { get; set; }
}