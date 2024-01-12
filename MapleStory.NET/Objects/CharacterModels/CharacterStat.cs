namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 스탯 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="FinalStat"> 현재 스탯 정보 리스트 </param>
/// <param name="RemainAp"> 잔여 AP </param>
public record CharacterStat(string CharacterClass, List<FinalStat> FinalStat, long? RemainAp)
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

/// <summary>
/// 현재 스탯 정보
/// </summary>
/// <param name="StatName"> 스탯 명 </param>
/// <param name="StatValue"> 스탯 값 </param>
public record FinalStat(string StatName, string StatValue);