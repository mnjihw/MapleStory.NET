namespace MapleStory.NET.Objects.CharacterModels.CharacterPetEquipment;
/// <summary>
/// 펫 장착 정보
/// </summary>
public class PetEquipment
{
    /// <summary>
    /// 아이템 명
    /// </summary>
    public string? ItemName { get; set; }
    /// <summary>
    /// 아이템 아이콘 URL
    /// </summary>
    public string? ItemIcon { get; set; }
    /// <summary>
    /// 아이템 설명
    /// </summary>
    public string? ItemDescription { get; set; }
    /// <summary>
    /// 아이템 표기상 옵션 리스트
    /// </summary>
    public List<ItemOption>? ItemOption { get; set; }
    /// <summary>
    /// 압그레이드 횟수
    /// </summary>
    public long ScrollUpgrade { get; set; }
    /// <summary>
    /// 업그레이드 가능 횟수
    /// </summary>
    public long ScrollUpgradeable { get; set; }
}