namespace MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
public class AdditionalCashItemEquipmentPreset
{
    public string? CashItemEquipmentPart { get; set; }
    public string? CashItemEquipmentSlot { get; set; }
    public string? CashItemName { get; set; }
    public string? CashItemIcon { get; set; }
    public string? CashItemDescription { get; set; }
    public List<CashItemOption>? CashItemOption { get; set; }
    private DateTimeOffset? _dateExpire;
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
    public string? CashItemLabel { get; set; }
    public List<CashItemColoringPrism>? CashItemColoringPrism { get; set; }
    public string? BasePresetItemDisableFlag { get; set; }
}