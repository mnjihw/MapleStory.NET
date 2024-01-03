namespace MapleStory.NET.Objects.CharacterModels.CharacterBasic;
public class CharacterBasic
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterName { get; set; }
    public string? WorldName { get; set; }
    public string? CharacterGender { get; set; }
    public string? CharacterClass { get; set; }
    public string? CharacterClassLevel { get; set; }
    public long CharacterLevel { get; set; }
    public long CharacterExp { get; set; }
    public string? CharacterExpRate { get; set; }
    public string? CharacterGuildName { get; set; }
    public string? CharacterImage { get; set; }
}
