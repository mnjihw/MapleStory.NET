namespace MapleStory.NET.Objects.CharacterModels.CharacterBasic;
/// <summary>
/// 캐릭터 기본 정보
/// </summary>
public class CharacterBasic
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
    /// 캐릭터 명
    /// </summary>
    public string? CharacterName { get; set; }
    /// <summary>
    /// 월드 명
    /// </summary>
    public string? WorldName { get; set; }
    /// <summary>
    /// 캐릭터 성별
    /// </summary>
    public string? CharacterGender { get; set; }
    /// <summary>
    /// 캐릭터 직업
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// 캐릭터 전직 차수
    /// </summary>
    public string? CharacterClassLevel { get; set; }
    /// <summary>
    /// 캐릭터 레벨
    /// </summary>
    public long CharacterLevel { get; set; }
    /// <summary>
    /// 현재 레벨에서 보유한 경험치
    /// </summary>
    public long CharacterExp { get; set; }
    /// <summary>
    /// 현재 레벨에서 경험치 퍼센트
    /// </summary>
    public string? CharacterExpRate { get; set; }
    /// <summary>
    /// 캐릭터 소속 길드 명
    /// </summary>
    public string? CharacterGuildName { get; set; }
    /// <summary>
    /// 캐릭터 외형 이미지 URL
    /// </summary>
    public string? CharacterImage { get; set; }
}
