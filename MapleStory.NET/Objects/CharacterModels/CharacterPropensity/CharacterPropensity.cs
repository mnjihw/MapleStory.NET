namespace MapleStory.NET.Objects.CharacterModels.CharacterPropensity;
public class CharacterPropesity
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public long CharismaLevel { get; set; }
    public long SensibilityLevel { get; set; }
    public long InsightLevel { get; set; }
    public long WillingnessLevel { get; set; }
    public long HandicraftLevel { get; set; }
    public long CharmLevel { get; set; }
}
