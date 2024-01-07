namespace MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
/// <summary>
/// Cash item equipment preset.
/// </summary>
public class CashItemEquipmentPreset
{
    /// <summary>
    /// Cash item equipment part name.
    /// </summary>
    public string? CashItemEquipmentPart { get; set; }
    /// <summary>
    /// Cash item equipment slot location.
    /// </summary>
    public string? CashItemEquipmentSlot { get; set; }
    /// <summary>
    /// Cash item name.
    /// </summary>
    public string? CashItemName { get; set; }
    /// <summary>
    /// Cash item icon URL.
    /// </summary>
    public string? CashItemIcon { get; set; }
    /// <summary>
    /// Cash item description.
    /// </summary>
    public string? CashItemDescription { get; set; }
    /// <summary>
    /// Cash item option.
    /// </summary>
    public List<CashItemOption>? CashItemOption { get; set; }
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// Cash item expiration date (KST).
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// Cash item option expiration date (KST).
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
    /// <summary>
    /// Cash item label.
    /// </summary>
    public string? CashItemLabel { get; set; }
    /// <summary>
    /// List of cash item coloring prisms.
    /// </summary>
    public List<CashItemColoringPrism>? CashItemColoringPrism { get; set; }
    /// <summary>
    /// Whether equipment sharing for preset 1 has been disabled without additional equipment on other presets.
    /// </summary>
    public string? BasePresetItemDisableFlag { get; set; }
}