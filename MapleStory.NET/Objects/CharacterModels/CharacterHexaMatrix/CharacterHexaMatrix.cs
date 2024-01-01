namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrix;
public class CharacterHexaMatrix
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public List<CharacterHexaCoreEquipment>? CharacterHexaCoreEquipment { get; set; }
}