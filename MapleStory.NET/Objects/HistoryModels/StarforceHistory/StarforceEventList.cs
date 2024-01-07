namespace MapleStory.NET.Objects.HistoryModels.StarforceHistory;
/// <summary>
/// 진행 중인 스타포스 강화 이벤트 정보
/// </summary>
public class StarforceEventList
{
    /// <summary>
    /// 이벤트 성공 확률
    /// </summary>
    public string? SuccessRate { get; set; }
    /// <summary>
    /// 이벤트 비용 할인율
    /// </summary>
    public string? CostDiscountRate { get; set; }
    /// <summary>
    /// 이벤트 강화 수치 가중값
    /// </summary>
    public string? PlusValue { get; set; }
    /// <summary>
    /// 이벤트 적용 강화 시도 가능한 n성 범위
    /// </summary>
    public string? StarforceEventRange { get; set; }
}