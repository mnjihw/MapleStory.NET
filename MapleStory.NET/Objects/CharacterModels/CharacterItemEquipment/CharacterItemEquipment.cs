namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
public class CharacterItemEquipment
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterGender { get; set; }
    public string? CharacterClass { get; set; }
    public List<ItemEquipment>? ItemEquipment { get; set; }
    public Title? Title { get; set; }
    public List<DragonEquipment>? DragonEquipment { get; set; }
    public List<MechanicEquipment>? MechanicEquipment { get; set; }
}

