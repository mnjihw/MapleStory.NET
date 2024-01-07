namespace MapleStory.NET.Objects.RankingModels.AchievementRanking;
/// <summary>
/// 업적 랭킹 세부정보
/// </summary>
public class RankingDetails
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// 업적 랭킹 순위
    /// </summary>
    public int Ranking { get; set; }
    /// <summary>
    /// 캐릭터 명
    /// </summary>
    public string? CharacterName { get; set; }
    /// <summary>
    /// 월드 명
    /// </summary>
    public string? WorldName { get; set; }
    /// <summary>
    /// 직업 명
    /// </summary>
    public string? ClassName { get; set; }
    /// <summary>
    /// 전직 직업 명
    /// </summary>
    public string? SubClassName { get; set; }
    /// <summary>
    /// 업적 등급
    /// </summary>
    public string? TrophyGrade { get; set; }
    /// <summary>
    /// 업적 점수
    /// </summary>
    public int TrophyScore { get; set; }
}
