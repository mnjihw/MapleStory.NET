namespace MapleStory.NET.Objects.CharacterModels.CharacterPetEquipment;
/// <summary>
/// 펫 버프 자동스킬 정보
/// </summary>
public class PetAutoSkill
{
    /// <summary>
    /// 첫 번째 슬롯에 등록된 자동 스킬
    /// </summary>
    public string? Skill_1 { get; set; }
    /// <summary>
    /// 첫 번째 슬롯에 등록된 자동 스킬 아이콘 URL
    /// </summary>
    public string? Skill_1Icon { get; set; }
    /// <summary>
    /// 두 번째 슬롯에 등록된 자동 스킬
    /// </summary>
    public string? Skill_2 { get; set; }
    /// <summary>
    /// 두 번째 슬롯에 등록된 자동 스킬 아이콘 URL
    /// </summary>
    public string? Skill_2Icon { get; set; }
}