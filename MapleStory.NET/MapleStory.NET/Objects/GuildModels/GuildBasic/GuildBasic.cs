namespace MapleStory.NET.Objects.GuildModels.GuildBasic;
public class GuildBasic
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? WorldName { get; set; }
    public string? GuildName { get; set; }
    public long GuildLevel { get; set; }
    public long GuildFame { get; set; }
    public long GuildPoint { get; set; }
    public string? GuildMasterName { get; set; }
    public long GuildMemberCount { get; set; }
    public List<string>? GuildMember { get; set; }
    public List<GuildSkill>? GuildSkill { get; set; }
    public List<GuildNoblesseSkill>? GuildNoblesseSkill { get; set; }
    public string? GuildMark { get; set; }
    public string? GuildMarkCustom { get; set; }
}
