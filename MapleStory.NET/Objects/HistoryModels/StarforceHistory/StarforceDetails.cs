namespace MapleStory.NET.Objects.HistoryModels.StarforceHistory;
/// <summary>
/// 스타포스 히스토리 세부정보
/// </summary>
public class StarforceHistoryDetails
{
    /// <summary>
    /// 스타포스 히스토리 식별자
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// 강화 시도 결과
    /// </summary>
    public string? ItemUpgradeResult { get; set; }
    /// <summary>
    /// 강화 시도 전 스타포스 수치
    /// </summary>
    public long BeforeStarforceCount { get; set; }
    /// <summary>
    /// 강화 시도 후 스타포스 수치
    /// </summary>
    public long AfterStarforceCount { get; set; }
    /// <summary>
    /// 스타 캐치
    /// </summary>
    public string? StarcatchResult { get; set; }
    /// <summary>
    /// 슈페리얼 장비
    /// </summary>
    public string? SuperiorItemFlag { get; set; }
    /// <summary>
    /// 파괴 방지
    /// </summary>
    public string? DestroyDefence { get; set; }
    /// <summary>
    /// 찬스 타임
    /// </summary>
    public string? ChanceTime { get; set; }
    /// <summary>
    /// 파괴 방지 필드 이벤트
    /// </summary>
    public string? EventFieldFlag { get; set; }
    /// <summary>
    /// 사용 주문서 명 
    /// </summary>
    public string? UpgradeItem { get; set; }
    /// <summary>
    /// 프로텍트 실드
    /// </summary>
    public string? ProtectShield { get; set; }
    /// <summary>
    /// 보너스 스탯 부여 아이템 여부
    /// </summary>
    public string? BonusStatUpgrade { get; set; }
    /// <summary>
    /// 캐릭터 명
    /// </summary>
    public string? CharacterName { get; set; }
    /// <summary>
    /// 월드 명
    /// </summary>
    public string? WorldName { get; set; }
    /// <summary>
    /// 대상 장비 아이템 명
    /// </summary>
    public string? TargetItem { get; set; }
    private DateTimeOffset? _dateCreate;
    /// <summary>
    /// 강화 일시 (KST)
    /// </summary>
    public DateTimeOffset? DateCreate
    {
        get => _dateCreate?.ToOffset(TimeSpan.FromHours(9));
        set => _dateCreate = value;
    }
    /// <summary>
    /// 진행 중인 스타포스 강화 이벤트 정보 리스트
    /// </summary>
    public List<StarforceEventList>? StarforceEventList { get; set; }
}