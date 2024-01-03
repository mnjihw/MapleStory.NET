namespace MapleStory.NET.Objects.RankingModels.AchievementRanking;
public class RankingDetails
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public int Ranking { get; set; }
    public string? CharacterName { get; set; }
    public string? WorldName { get; set; }
    public string? ClassName { get; set; }
    public string? SubClassName { get; set; }
    public string? TrophyGrade { get; set; }
    public int TrophyScore { get; set; }
}
