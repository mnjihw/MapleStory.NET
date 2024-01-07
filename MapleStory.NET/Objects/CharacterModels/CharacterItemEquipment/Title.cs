namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
/// <summary>
/// 칭호 정보
/// </summary>
public class Title
{
    /// <summary>
    /// 칭호 장비 명
    /// </summary>
    public string? TitleName { get; set; }
    /// <summary>
    /// 칭호 아이콘 URL
    /// </summary>
    public string? TitleIcon { get; set; }
    /// <summary>
    /// 칭호 설명
    /// </summary>
    public string? TitleDescription { get; set; }
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 칭호 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// 칭호 옵션 유효 기간 (KST, expired: 만료, null: 무제한)
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
}