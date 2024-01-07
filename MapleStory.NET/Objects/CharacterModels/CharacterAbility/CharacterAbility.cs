namespace MapleStory.NET.Objects.CharacterModels.CharacterAbility;
/// <summary>
/// 캐릭터 어빌리티
/// </summary>
public class CharacterAbility
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
    /// 어빌리티 등급
    /// </summary>
    public string? AbilityGrade { get; set; }
    /// <summary>
    /// 어빌리티 정보 리스트
    /// </summary>
    public List<AbilityInfo>? AbilityInfo { get; set; }
    /// <summary>
    /// 보유 명성치
    /// </summary>
    public long RemainFame { get; set; }
}