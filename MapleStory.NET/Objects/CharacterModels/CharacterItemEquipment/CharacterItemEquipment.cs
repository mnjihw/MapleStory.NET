namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
/// <summary>
/// 장착 장비 정보
/// </summary>
public class CharacterItemEquipment
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
    /// 캐릭터 성별
    /// </summary>
    public string? CharacterGender { get; set; }
    /// <summary>
    /// 캐릭터 직업
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// 장비 정보 리스트
    /// </summary>
    public List<ItemEquipment>? ItemEquipment { get; set; }
    /// <summary>
    /// 칭호 정보
    /// </summary>
    public Title? Title { get; set; }
    /// <summary>
    /// 에반 드래곤 장비 정보 리스트 (에반인 경우 응답)
    /// </summary>
    public List<DragonEquipment>? DragonEquipment { get; set; }
    /// <summary>
    /// 메카닉 장비 정보 리스트 (메카닉인 경우 응답)
    /// </summary>
    public List<MechanicEquipment>? MechanicEquipment { get; set; }
}

