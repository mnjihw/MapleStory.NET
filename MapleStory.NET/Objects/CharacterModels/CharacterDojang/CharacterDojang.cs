namespace MapleStory.NET.Objects.CharacterModels.CharacterDojang;
public class CharacterDojang
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public string? WorldName { get; set; }
    public long DojangBestFloor { get; set; }
    private DateTimeOffset? _dateDojangRecord;
    public DateTimeOffset? DateDojangRecord
    {
        get => _dateDojangRecord?.ToOffset(TimeSpan.FromHours(9));
        set => _dateDojangRecord = value;
    }
    public long DojangBestTime { get; set; }
}