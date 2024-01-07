namespace MapleStory.NET.Objects.HistoryModels.CubeHistory;
/// <summary>
/// 큐브 히스토리
/// </summary>
public class CubeHistory
{
    /// <summary>
    /// 결과 건수
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// 페이징 처리를 위한 cursor
    /// </summary>
    public string? NextCursor { get; set; }
    /// <summary>
    /// 큐브 히스토리 세부정보 리스트
    /// </summary>
    [JsonPropertyName("cube_history")]
    public List<CubeHistoryDetails>? CubeHistoryDetails { get; set; }
}