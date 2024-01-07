namespace MapleStory.NET.Objects.UnionModels.Union;
/// <summary>
/// 유니온
/// </summary>
public class Union
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
    /// 유니온 레벨
    /// </summary>
    public long UnionLevel { get; set; }
    /// <summary>
    /// 유니온 등급
    /// </summary>
    public string? UnionGrade { get; set; }
}