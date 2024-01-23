namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 무릉도장 최고 기록 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="DojangBestFloor"> 무릉도장 최고 기록 층수 </param>
/// <param name="DojangBestTime"> 무릉도장 최고 층수 클리어에 걸린 시간 (초) </param>
public record CharacterDojang(string? CharacterClass, string? WorldName, long? DojangBestFloor, long? DojangBestTime)
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

    private DateTimeOffset? _dateDojangRecord;
    /// <summary>
    /// 무릉도장 최고 기록 달성일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? DateDojangRecord
    {
        get => _dateDojangRecord?.ToOffset(TimeSpan.FromHours(9));
        set => _dateDojangRecord = value;
    }
}