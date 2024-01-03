namespace MapleStory.NET.Objects.CharacterModels.CharacterAbility;

public class CharacterAbility
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? AbilityGrade { get; set; }
    public List<AbilityInfo>? AbilityInfo { get; set; }
    public long RemainFame { get; set; }
}