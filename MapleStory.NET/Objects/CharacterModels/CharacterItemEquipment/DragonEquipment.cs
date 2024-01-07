namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
/// <summary>
/// Evan's dragon equipment. Returned if the character is an Evan.
/// </summary>
public class DragonEquipment
{
    /// <summary>
    /// Name of equipment part.
    /// </summary>
    public string? ItemEquipmentPart { get; set; }
    /// <summary>
    /// Equipment slot location.
    /// </summary>
    public string? EquipmentSlot { get; set; }
    /// <summary>
    /// Item name.
    /// </summary>
    public string? ItemName { get; set; }
    /// <summary>
    /// Item icon URL.
    /// </summary>
    public string? ItemIcon { get; set; }
    /// <summary>
    /// Item description.
    /// </summary>
    public string? ItemDescription { get; set; }
    /// <summary>
    /// Item shape name.
    /// </summary>
    public string? ItemShapeName { get; set; }
    /// <summary>
    /// Item shape icon URL.
    /// </summary>
    public string? ItemShapeIcon { get; set; }
    /// <summary>
    /// Gender restriction for the item.
    /// </summary>
    public string? Gender { get; set; }
    /// <summary>
    /// Item's total option.
    /// </summary>
    public List<ItemTotalOption>? ItemTotalOption { get; set; }
    /// <summary>
    /// Item's base option.
    /// </summary>
    public List<ItemBaseOption>? ItemBaseOption { get; set; }
    /// <summary>
    /// Equipment level increase.
    /// </summary>
    public long EquipmentLevelIncrease { get; set; }
    /// <summary>
    /// Item's exceptional option.
    /// </summary>
    public List<ItemExceptionalOption>? ItemExceptionalOption { get; set; }
    /// <summary>
    /// Item's add option.
    /// </summary>
    public List<ItemAddOption>? ItemAddOption { get; set; }
    /// <summary>
    /// Growth EXP.
    /// </summary>
    public long GrowthExp { get; set; }
    /// <summary>
    /// Growth level.
    /// </summary>
    public long GrowthLevel { get; set; }
    /// <summary>
    /// Scorll upgrade.
    /// </summary>
    public string? ScrollUpgrade { get; set; }
    /// <summary>
    /// Cuttable count.
    /// </summary>
    public string? CuttableCount { get; set; }
    /// <summary>
    /// Whether Golden Hammer is applied. (1: Applied, Other Values: Not Applied)
    /// </summary>
    public string? GoldenHammerFlag { get; set; }
    /// <summary>
    /// Number of recoverable times.
    /// </summary>
    public string? ScrollResilienceCount { get; set; }
    /// <summary>
    /// Number of upgradeable times.
    /// </summary>
    public string? ScrollUpgradeableCount { get; set; }
    /// <summary>
    /// Soul name.
    /// </summary>
    public string? SoulName { get; set; }
    /// <summary>
    /// Soul option.
    /// </summary>
    public string? SoulOption { get; set; }
    /// <summary>
    /// Item's etc option.
    /// </summary>
    public List<ItemEtcOption>? ItemEtcOption { get; set; }
    /// <summary>
    /// Star Force Enhancement level.
    /// </summary>
    public string? Starforce { get; set; }
    /// <summary>
    /// Whether Amazing Equip Enhancement Scroll is applied. (0: Not Applied, 1: Applied)
    /// </summary>
    public string? StarforceScrollFlag { get; set; }
    /// <summary>
    /// Item's Star Force option.
    /// </summary>
    public List<ItemStarforceOption>? ItemStarforceOption { get; set; }
    /// <summary>
    /// Special ring level.
    /// </summary>
    public long SpecialRingLevel { get; set; }
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// Item expiration date.
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}
