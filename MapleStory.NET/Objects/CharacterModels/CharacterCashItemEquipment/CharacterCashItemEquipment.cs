namespace MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
/// <summary>
/// Character's cash item equipment.
/// </summary>
public class CharacterCashItemEquipment
{
    private DateTimeOffset? _date;
    /// <summary>
    /// Reference date (KST).
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// Character's gender.
    /// </summary>
    public string? CharacterGender { get; set; }
    /// <summary>
    /// Character's class.
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// Case equipment preset number applied.
    /// </summary>
    public long PresetNo { get; set; }
    /// <summary>
    /// List of first preset cash item equipments.
    /// </summary>
    public List<CashItemEquipmentPreset>? CashItemEquipmentPreset_1 { get; set; }
    /// <summary>
    /// List of second preset cash item equipments.
    /// </summary>
    public List<CashItemEquipmentPreset>? CashItemEquipmentPreset_2 { get; set; }
    /// <summary>
    /// List of third preset cash item equipments.
    /// </summary>
    public List<CashItemEquipmentPreset>? CashItemEquipmentPreset_3 { get; set; }
    /// <summary>
    /// List of first preset additional cash item equipments.
    /// </summary>
    public List<AdditionalCashItemEquipmentPreset>? AdditionalCashItemEquipmentPreset_1 { get; set; }
    /// <summary>
    /// List of second preset additional cash item equipments.
    /// </summary>
    public List<AdditionalCashItemEquipmentPreset>? AdditionalCashItemEquipmentPreset_2 { get; set; }
    /// <summary>
    /// List of third preset additional cash item equipments.
    /// </summary>
    public List<AdditionalCashItemEquipmentPreset>? AdditionalCashItemEquipmentPreset_3 { get; set; }
}