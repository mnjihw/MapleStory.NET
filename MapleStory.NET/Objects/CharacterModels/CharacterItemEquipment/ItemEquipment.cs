namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
public class ItemEquipment
{
    public string? ItemEquipmentPart { get; set; }
    public string? ItemEquipmentSlot { get; set; }
    public string? ItemName { get; set; }
    public string? ItemIcon { get; set; }
    public string? ItemDescription { get; set; }
    public string? ItemShapeName { get; set; }
    public string? ItemShapeIcon { get; set; }
    public string? ItemGender { get; set; }
    public ItemTotalOption? ItemTotalOption { get; set; }
    public ItemBaseOption? ItemBaseOption { get; set; }
    public string? PotentialOptionGrade { get; set; }
    public string? AdditionalPotentialOptionGrade { get; set; }
    public string? PotentialOption_1 { get; set; }
    public string? PotentialOption_2 { get; set; }
    public string? PotentialOption_3 { get; set; }
    public string? AdditionalPotentialOption_1 { get; set; }
    public string? AdditionalPotentialOption_2 { get; set; }
    public string? AdditionalPotentialOption_3 { get; set; }
    public long EquipmentLevelIncrease { get; set; }
    public ItemExceptionalOption? ItemExceptionalOption { get; set; }
    public ItemAddOption? ItemAddOption { get; set; }
    public long GrowthExp { get; set; }
    public long GrowthLevel { get; set; }
    public string? ScrollUpgrade { get; set; }
    public string? CuttableCount { get; set; }
    public string? GoldenHammerFlag { get; set; }
    public string? ScrollResilienceCount { get; set; }
    public string? ScrollUpgradeableCount { get; set; }
    public string? SoulName { get; set; }
    public string? SoulOption { get; set; }
    public ItemEtcOption? ItemEtcOption { get; set; }
    public string? Starforce { get; set; }
    public string? StarforceScrollFlag { get; set; }
    public ItemEtcOption? ItemStarforceOption { get; set; }
    public long SpecialRingLevel { get; set; }
    private DateTimeOffset? _dateExpire;
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}
