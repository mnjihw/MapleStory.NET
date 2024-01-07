namespace MapleStory.NET.Objects.GuildModels.GuildBasic;
/// <summary>
/// 길드 기본 정보
/// </summary>
public class GuildBasic
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// 월드 명
    /// </summary>
    public string? WorldName { get; set; }
    /// <summary>
    /// 길드 명
    /// </summary>
    public string? GuildName { get; set; }
    /// <summary>
    /// 길드 레벨
    /// </summary>
    public long GuildLevel { get; set; }
    /// <summary>
    /// 길드 명성치
    /// </summary>
    public long GuildFame { get; set; }
    /// <summary>
    /// 길드 포인트(GP)
    /// </summary>
    public long GuildPoint { get; set; }
    /// <summary>
    /// 길드 마스터 캐릭터 명
    /// </summary>
    public string? GuildMasterName { get; set; }
    /// <summary>
    /// 길드원 수
    /// </summary>
    public long GuildMemberCount { get; set; }
    /// <summary>
    /// 길드원 리스트
    /// </summary>
    public List<string>? GuildMember { get; set; }
    /// <summary>
    /// 길드 스킬 리스트
    /// </summary>
    public List<GuildSkill>? GuildSkill { get; set; }
    /// <summary>
    /// 길드 노블레스 스킬 리스트
    /// </summary>
    public List<GuildNoblesseSkill>? GuildNoblesseSkill { get; set; }
    /// <summary>
    /// 조합형 길드 마크
    /// </summary>
    public string? GuildMark { get; set; }
    /// <summary>
    /// 커스텀 길드 마크 (BASE64 인코딩)
    /// </summary>
    public string? GuildMarkCustom { get; set; }
}
