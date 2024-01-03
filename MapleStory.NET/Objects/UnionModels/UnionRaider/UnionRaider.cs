namespace MapleStory.NET.Objects.UnionModels.UnionRaider;
public class UnionRaider
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public List<string>? UnionRaiderStat { get; set; }
    public List<string>? UnionOccupiedStat { get; set; }
    public List<UnionInnerStat>? UnionInnerStat { get; set; }
    public List<UnionBlock>? UnionBlock { get; set; }
}