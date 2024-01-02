namespace MapleStory.NET.Objects.CharacterModels.CharacterPopularity;
public class CharacterPopularity
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public long Popularity { get; set; }
}
