namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 성향 정보
/// </summary>
/// <param name="CharismaLevel"> 카리스마 레벨 </param>
/// <param name="SensibilityLevel"> 감성 레벨 </param>
/// <param name="InsightLevel"> 통찰력 레벨 </param>
/// <param name="WillingnessLevel"> 의지 레벨 </param>
/// <param name="HandicraftLevel"> 손재주 레벨 </param>
/// <param name="CharmLevel"> 매력 레벨 </param>
public record CharacterPropesity(long? CharismaLevel, long? SensibilityLevel, long? InsightLevel, long? WillingnessLevel, long? HandicraftLevel, long? CharmLevel)
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
}
