namespace MapleStory.NET.Objects.RankingModels.GuildRanking;
/// <summary>
/// 길드 랭킹 세부정보
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
    /// 길드 랭킹 순위
    /// </summary>
    public int Ranking { get; set; }
    /// <summary>
    /// 길드 명
    /// </summary>
    public string? GuildName { get; set; }
    /// <summary>
    /// 월드 명
    /// </summary>
    public string? WorldName { get; set; }
    /// <summary>
    /// 길드 레벨
    /// </summary>
    public int GuildLevel { get; set; }
    /// <summary>
    /// 길드 마스터 캐릭터 명
    /// </summary>
    public string? GuildMasterName { get; set; }
    /// <summary>
    /// 길드 마크
    /// </summary>
    public string? GuildMark { get; set; }
    /// <summary>
    /// 길드 포인트
    /// </summary>
    public long GuildPoint { get; set; }
}
