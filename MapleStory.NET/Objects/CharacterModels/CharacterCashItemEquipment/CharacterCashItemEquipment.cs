namespace MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
public class CharacterCashItemEquipment
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterGender { get; set; }
    public string? CharacterClass { get; set; }
    public long PresetNo { get; set; }
    public List<CashItemEquipmentPreset>? CashItemEquipmentPreset_1 { get; set; }
    public List<CashItemEquipmentPreset>? CashItemEquipmentPreset_2 { get; set; }
    public List<CashItemEquipmentPreset>? CashItemEquipmentPreset_3 { get; set; }
    public List<AdditionalCashItemEquipmentPreset>? AdditionalCashItemEquipmentPreset_1 { get; set; }
    public List<AdditionalCashItemEquipmentPreset>? AdditionalCashItemEquipmentPreset_2 { get; set; }
    public List<AdditionalCashItemEquipmentPreset>? AdditionalCashItemEquipmentPreset_3 { get; set; }
}