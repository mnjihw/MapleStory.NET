namespace MapleStory.NET.Objects.CharacterModels.CharacterSkill;
/// <summary>
/// 캐릭터 스킬 정보
/// </summary>
public class CharacterSkill
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
    /// 스킬 전직 차수
    /// </summary>
    public string? CharacterSkillGrade { get; set; }
    /// <summary>
    /// 스킬 세부정보 리스트
    /// </summary>
    [JsonPropertyName("character_skill")]
    public List<CharacterSkillDetails>? CharacterSkillDetails { get; set; }
}