namespace MapleStory.NET.Objects.HistoryModels.StarforceHistory;
/// <summary>
/// 스타포스 히스토리 세부정보
/// </summary>
public class StarforceHistory
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
    /// 스타포스 히스토리 세부정보 리스트
    /// </summary>
    [JsonPropertyName("starforce_history")]
    public List<StarforceHistoryDetails>? StarforceHistoryDetails { get; set; }
}