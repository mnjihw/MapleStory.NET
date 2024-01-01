namespace MapleStory.NET.Objects.CharacterModels.CharacterSetEffect;
public class CharacterSetEffect
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public List<SetEffect>? SetEffect { get; set; }
}