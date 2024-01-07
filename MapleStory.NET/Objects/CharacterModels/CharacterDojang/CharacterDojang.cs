namespace MapleStory.NET.Objects.CharacterModels.CharacterDojang;
/// <summary>
/// 무릉도장 최고 기록 정보
/// </summary>
public class CharacterDojang
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
    /// 월드 명
    /// </summary>
    public string? WorldName { get; set; }
    /// <summary>
    /// 무릉도장 최고 기록 층수
    /// </summary>
    public long DojangBestFloor { get; set; }
    private DateTimeOffset? _dateDojangRecord;
    /// <summary>
    /// 무릉도장 최고 기록 달성일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? DateDojangRecord
    {
        get => _dateDojangRecord?.ToOffset(TimeSpan.FromHours(9));
        set => _dateDojangRecord = value;
    }
    /// <summary>
    /// 무릉도장 최고 층수 클리어에 걸린 시간 (초)
    /// </summary>
    public long DojangBestTime { get; set; }
}