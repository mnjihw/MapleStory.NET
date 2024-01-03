namespace MapleStory.NET.Objects.RankingModels.GuildRanking;
public class RankingDetails
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public int Ranking { get; set; }
    public string? GuildName { get; set; }
    public string? WorldName { get; set; }
    public int GuildLevel { get; set; }
    public string? GuildMasterName { get; set; }
    public string? GuildMark { get; set; }
    public long GuildPoint { get; set; }
}
