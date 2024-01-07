namespace MapleStory.NET.Objects.HistoryModels.CubeHistory;
/// <summary>
/// 큐브 히스토리 세부정보
/// </summary>
public class CubeHistoryDetails
{
    /// <summary>
    /// 큐브 히스토리 식별자
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// 캐릭터 명
    /// </summary>
    public string? CharacterName { get; set; }
    private DateTimeOffset? _dateCreate;
    /// <summary>
    /// 사용 일시 (KST)
    /// </summary>
    public DateTimeOffset? DateCreate
    {
        get => _dateCreate?.ToOffset(TimeSpan.FromHours(9));
        set => _dateCreate = value;
    }
    /// <summary>
    /// 사용 큐브
    /// </summary>
    public string? CubeType { get; set; }
    /// <summary>
    /// 사영 결과
    /// </summary>
    public string? ItemUpgradeResult { get; set; }
    /// <summary>
    /// 미라클 타임 적용 여부
    /// </summary>
    public string? MiracleTimeFlag { get; set; }
    /// <summary>
    /// 장비 분류
    /// </summary>
    public string? ItemEquipmentPart { get; set; }
    /// <summary>
    /// 장비 레벨
    /// </summary>
    public int ItemLevel { get; set; }
    /// <summary>
    /// 큐브 사용한 장비
    /// </summary>
    public string? TargetItem { get; set; }
    /// <summary>
    /// 잠재능력 등급
    /// </summary>
    public string? PotentialOptionGrade { get; set; }
    /// <summary>
    /// 에디셔널 잠재능력 등급
    /// </summary>
    public string? AdditionalPotentialOptionGrade { get; set; }
    /// <summary>
    /// 천장에 도달하여 확정 등급 상승한 여부
    /// </summary>
    public bool UpgradeGuarantee { get; set; }
    /// <summary>
    /// 현재까지 쌓은 스택
    /// </summary>
    public int UpgradeGuaranteeCount { get; set; }
    /// <summary>
    /// 사용 전 잠재능력 옵션 리스트
    /// </summary>
    public List<PotentialOption>? BeforePotentialOption { get; set; }
    /// <summary>
    /// 사용 전 에디셔널 잠재능력 옵션 리스트
    /// </summary>
    public List<PotentialOption>? BeforeAdditionalPotentialOption { get; set; }
    /// <summary>
    /// 사용 후 잠재능력 옵션 리스트
    /// </summary>
    public List<PotentialOption>? AfterPotentialOption { get; set; }
    /// <summary>
    /// 사용 후 에디셔널 잠재능력 옵션 리스트
    /// </summary>
    public List<PotentialOption>? AfterAdditionalPotentialOption { get; set; }
}