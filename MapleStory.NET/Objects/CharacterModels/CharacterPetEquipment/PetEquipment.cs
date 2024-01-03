namespace MapleStory.NET.Objects.CharacterModels.CharacterPetEquipment;
public class PetEquipment
{
    public string? ItemName { get; set; }
    public string? ItemIcon { get; set; }
    public string? ItemDescription { get; set; }
    public List<ItemOption>? ItemOption { get; set; }
    public long ScrollUpgrade { get; set; }
    public long ScrollUpgradeable { get; set; }
}