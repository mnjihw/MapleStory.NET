namespace MapleStory.NET.Objects.UnionModels.Union;
public class Union
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public long UnionLevel { get; set; }
    public string? UnionGrade { get; set; }
}