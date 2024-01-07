namespace MapleStory.NET.Objects.CharacterModels.CharacterStat;
/// <summary>
/// 캐릭터 스탯 정보
/// </summary>
public class CharacterStat
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
    /// 캐릭터 직업
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// 현재 스탯 정보 리스트
    /// </summary>
    public List<FinalStat>? FinalStat { get; set; }
    /// <summary>
    /// 잔여 AP
    /// </summary>
    public long RemainAp { get; set; }
}