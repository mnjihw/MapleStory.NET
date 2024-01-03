namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
public class Title
{
    public string? TitleName { get; set; }
    public string? TitleIcon { get; set; }
    public string? TitleDescription { get; set; }
    private DateTimeOffset? _dateExpire;
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
}