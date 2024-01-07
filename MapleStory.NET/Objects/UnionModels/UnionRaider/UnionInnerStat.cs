namespace MapleStory.NET.Objects.UnionModels.UnionRaider;
/// <summary>
/// 유니온 공격대 배치
/// </summary>
public class UnionInnerStat
{
    /// <summary>
    /// 공격대 배치 위치 (11시 방향부터 시계 방향 순서대로 0~7)
    /// </summary>
    public string? StatFieldId { get; set; }
    /// <summary>
    /// 해당 지역 점령 효과
    /// </summary>
    public string? StatFieldEffect { get; set; }
}
