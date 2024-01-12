namespace MapleStory.NET.Objects;

/// <summary>
/// 에러 세부정보
/// </summary>
/// <param name="Name"> 에러 명 </param>
/// <param name="Message"> 에러 설명 </param>
public record ErrorDetails(string? Name, string? Message);
