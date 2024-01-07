namespace MapleStory.NET.Objects.CharacterModels.CharacterPropensity;
/// <summary>
/// 캐릭터 성향 정보
/// </summary>
public class CharacterPropesity
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
    /// 카리스마 레벨
    /// </summary>
    public long CharismaLevel { get; set; }
    /// <summary>
    /// 감성 레벨
    /// </summary>
    public long SensibilityLevel { get; set; }
    /// <summary>
    /// 통찰력 레벨
    /// </summary>
    public long InsightLevel { get; set; }
    /// <summary>
    /// 의지 레벨
    /// </summary>
    public long WillingnessLevel { get; set; }
    /// <summary>
    /// 손재주 레벨
    /// </summary>
    public long HandicraftLevel { get; set; }
    /// <summary>
    /// 매력 레벨
    /// </summary>
    public long CharmLevel { get; set; }
}
