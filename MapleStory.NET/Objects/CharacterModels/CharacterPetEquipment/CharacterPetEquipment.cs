namespace MapleStory.NET.Objects.CharacterModels.CharacterPetEquipment;
/// <summary>
/// 캐릭터 펫 장비 정보
/// </summary>
public class CharacterPetEquipment
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
    /// 펫1 명
    /// </summary>
    public string? Pet_1Name { get; set; }
    /// <summary>
    /// 펫1 닉네임
    /// </summary>
    public string? Pet_1Nickname { get; set; }
    /// <summary>
    /// 펫1 아이콘 URL
    /// </summary>
    public string? Pet_1Icon { get; set; }
    /// <summary>
    /// 펫1 설명
    /// </summary>
    public string? Pet_1Description { get; set; }
    /// <summary>
    /// 펫1 장착 정보
    /// </summary>
    public PetEquipment? Pet_1Equipment { get; set; }
    /// <summary>
    /// 펫1 펫 버프 자동스킬 정보
    /// </summary>
    public PetAutoSkill? Pet_1AutoSkill { get; set; }
    /// <summary>
    /// 펫1 원더 펫 종류
    /// </summary>
    public string? Pet_1PetType { get; set; }
    /// <summary>
    /// 펫1 펫 보유 스킬 리스트
    /// </summary>
    public List<string>? Pet_1Skill { get; set; }
    /// <summary>
    /// 펫1 마법의 시간 (KST, 시간 단위 데이터로 분은 0으로 고정)
    /// </summary>
    public string? Pet_1DateExpire { get; set; }
    /// <summary>
    /// 펫2 명
    /// </summary>
    public string? Pet_2Name { get; set; }
    /// <summary>
    /// 펫2 닉네임
    /// </summary>
    public string? Pet_2Nickname { get; set; }
    /// <summary>
    /// 펫2 아이콘 URL
    /// </summary>
    public string? Pet_2Icon { get; set; }
    /// <summary>
    /// 펫2 설명
    /// </summary>
    public string? Pet_2Description { get; set; }
    /// <summary>
    /// 펫2 장착 정보
    /// </summary>
    public PetEquipment? Pet_2Equipment { get; set; }
    /// <summary>
    /// 펫2 펫 버프 자동 스킬 정보
    /// </summary>
    public PetAutoSkill? Pet_2AutoSkill { get; set; }
    /// <summary>
    /// 펫2 원더 펫 종류
    /// </summary>
    public string? Pet_2PetType { get; set; }
    /// <summary>
    /// 펫2 펫 보유 스킬 리스트
    /// </summary>
    public List<string>? Pet_2Skill { get; set; }
    /// <summary>
    /// 펫2 마법의 시간 (KST, 시간 단위 데이터로 분은 0으로 고정)
    /// </summary>
    public string? Pet_2DateExpire { get; set; }
    /// <summary>
    /// 펫3 명
    /// </summary>
    public string? Pet_3Name { get; set; }
    /// <summary>
    /// 펫3 닉네임
    /// </summary>
    public string? Pet_3Nickname { get; set; }
    /// <summary>
    /// 펫3 아이콘 URL
    /// </summary>
    public string? Pet_3Icon { get; set; }
    /// <summary>
    /// 펫3 설명
    /// </summary>
    public string? Pet_3Description { get; set; }
    /// <summary>
    /// 펫3 장착 정보
    /// </summary>
    public PetEquipment? Pet_3Equipment { get; set; }
    /// <summary>
    /// 펫3 펫 버프 자동 스킬 정보
    /// </summary>
    public PetAutoSkill? Pet_3AutoSkill { get; set; }
    /// <summary>
    /// 펫3 원더 펫 종류
    /// </summary>
    public string? Pet_3PetType { get; set; }
    /// <summary>
    /// 펫3 펫 보유 스킬 리스트
    /// </summary>
    public List<string>? Pet_3Skill { get; set; }
    /// <summary>
    /// 펫3 마법의 시간 (KST, 시간 단위 데이터로 분은 0으로 고정)
    /// </summary>
    public string? Pet_3DateExpire { get; set; }
}