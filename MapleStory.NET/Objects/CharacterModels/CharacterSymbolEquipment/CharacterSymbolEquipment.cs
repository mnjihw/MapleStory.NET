namespace MapleStory.NET.Objects.CharacterModels.CharacterSymbolEquipment;
public class CharacterSymbolEquipment
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public List<Symbol>? Symbol { get; set; }
}