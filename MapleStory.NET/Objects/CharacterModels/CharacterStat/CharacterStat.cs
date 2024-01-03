namespace MapleStory.NET.Objects.CharacterModels.CharacterStat;
public class CharacterStat
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public List<FinalStat>? FinalStat { get; set; }
    public long RemainAp { get; set; }
}