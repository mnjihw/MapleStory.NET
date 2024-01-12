namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 인기도 정보
/// </summary>
/// <param name="Popularity"> 캐릭터 인기도 </param>
public record CharacterPopularity(long? Popularity)
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
