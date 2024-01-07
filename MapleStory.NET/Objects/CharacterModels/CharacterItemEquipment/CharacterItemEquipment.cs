namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
/// <summary>
/// Character's item equipment.
/// </summary>
public class CharacterItemEquipment
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
    /// List of item equipments.
    /// </summary>
    public List<ItemEquipment>? ItemEquipment { get; set; }
    /// <summary>
    /// Title data.
    /// </summary>
    public Title? Title { get; set; }
    /// <summary>
    /// List of dragon equipments.
    /// </summary>
    public List<DragonEquipment>? DragonEquipment { get; set; }
    /// <summary>
    /// List of mechanic equipments.
    /// </summary>
    public List<MechanicEquipment>? MechanicEquipment { get; set; }
}

