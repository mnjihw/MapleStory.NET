namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
public class MechanicEquipment
{
    public string? ItemEquipmentPart { get; set; }
    public string? EquipmentSlot { get; set; }
    public string? ItemName { get; set; }
    public string? ItemIcon { get; set; }
    public string? ItemDescription { get; set; }
    public string? ItemShapeName { get; set; }
    public string? ItemShapeIcon { get; set; }
    public string? Gender { get; set; }
    public List<ItemTotalOption>? ItemTotalOption { get; set; }
    public List<ItemBaseOption>? ItemBaseOption { get; set; }
    public long EquipmentLevelIncrease { get; set; }
    public List<ItemExceptionalOption>? ItemExceptionalOption { get; set; }
    public List<ItemAddOption>? ItemAddOption { get; set; }
    public long GrowthExp { get; set; }
    public long GrowthLevel { get; set; }
    public string? ScrollUpgrade { get; set; }
    public string? CuttableCount { get; set; }
    public string? GoldenHammerFlag { get; set; }
    public string? ScrollResilienceCount { get; set; }
    public string? ScrollUpgradeableCount { get; set; }
    public string? SoulName { get; set; }
    public string? SoulOption { get; set; }
    public List<ItemEtcOption>? ItemEtcOption { get; set; }
    public string? Starforce { get; set; }
    public string? StarforceScrollFlag { get; set; }
    public List<ItemStarforceOption>? ItemStarforceOption { get; set; }
    public long SpecialRingLevel { get; set; }
    private DateTimeOffset? _dateExpire;
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}
