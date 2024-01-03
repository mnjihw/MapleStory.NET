namespace MapleStory.NET.Objects.CharacterModels.CharacterVMatrix;
public class CharacterVMatrix
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public List<CharacterVCoreEquipment>? CharacterVCoreEquipment { get; set; }
    public long CharacterVMatrixRemainSlotUpgradePoint { get; set; }
}