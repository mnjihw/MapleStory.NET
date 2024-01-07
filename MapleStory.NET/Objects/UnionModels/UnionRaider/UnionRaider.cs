namespace MapleStory.NET.Objects.UnionModels.UnionRaider;
/// <summary>
/// 유니온 공격대
/// </summary>
public class UnionRaider
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// 유니온 공격대원 효과 리스트
    /// </summary>
    public List<string>? UnionRaiderStat { get; set; }
    /// <summary>
    /// 유니온 공격대 점령 효과 리스트
    /// </summary>
    public List<string>? UnionOccupiedStat { get; set; }
    /// <summary>
    /// 유니온 공격대 배치 리스트
    /// </summary>
    public List<UnionInnerStat>? UnionInnerStat { get; set; }
    /// <summary>
    /// 유니온 블록 정보 리스트
    /// </summary>
    public List<UnionBlock>? UnionBlock { get; set; }
}