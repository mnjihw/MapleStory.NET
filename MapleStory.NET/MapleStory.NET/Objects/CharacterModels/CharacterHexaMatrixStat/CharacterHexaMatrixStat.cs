namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrixStat;
public class CharacterHexaMatrixStat
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public List<CharacterHexaStatCore>? CharacterHexaStatCore { get; set; }
    public List<PresetHexaStatCore>? PresetHexaStatCore { get; set; }
}