namespace MapleStory.NET.Objects;

/// <summary>
/// 에러 응답
/// </summary>
/// <param name="Error"> 에러 세부정보 </param>
public record ErrorResponse(ErrorDetails? Error);