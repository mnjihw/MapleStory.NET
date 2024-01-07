namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
/// <summary>
/// 
/// </summary>
public class ItemEquipment
{
    /// <summary>
    /// 장비 부위 명
    /// </summary>
    public string? ItemEquipmentPart { get; set; }
    /// <summary>
    /// 장비 슬롯 위치
    /// </summary>
    public string? ItemEquipmentSlot { get; set; }
    /// <summary>
    /// 장비 명
    /// </summary>
    public string? ItemName { get; set; }
    /// <summary>
    /// 장비 아이콘 URL
    /// </summary>
    public string? ItemIcon { get; set; }
    /// <summary>
    /// 장비 설명
    /// </summary>
    public string? ItemDescription { get; set; }
    /// <summary>
    /// 장비 외형
    /// </summary>
    public string? ItemShapeName { get; set; }
    /// <summary>
    /// 장비 외형 아이콘 URL
    /// </summary>
    public string? ItemShapeIcon { get; set; }
    /// <summary>
    /// 전용 성별
    /// </summary>
    public string? ItemGender { get; set; }
    /// <summary>
    /// 장비 최종 옵션 정보
    /// </summary>
    public ItemTotalOption? ItemTotalOption { get; set; }
    /// <summary>
    /// 장비 기본 옵션 정보
    /// </summary>
    public ItemBaseOption? ItemBaseOption { get; set; }
    /// <summary>
    /// 잠재능력 등급
    /// </summary>
    public string? PotentialOptionGrade { get; set; }
    /// <summary>
    /// 에디셔널 잠재능력 등급
    /// </summary>
    public string? AdditionalPotentialOptionGrade { get; set; }
    /// <summary>
    /// 잠재능력 첫 번째 옵션
    /// </summary>
    public string? PotentialOption_1 { get; set; }
    /// <summary>
    /// 잠재능력 두 번째 옵션
    /// </summary>
    public string? PotentialOption_2 { get; set; }
    /// <summary>
    /// 잠재능력 세 번째 옵션
    /// </summary>
    public string? PotentialOption_3 { get; set; }
    /// <summary>
    /// 에디셔널 잠재능력 첫 번째 옵션
    /// </summary>
    public string? AdditionalPotentialOption_1 { get; set; }
    /// <summary>
    /// 에디셔널 잠재능력 두 번째 옵션
    /// </summary>
    public string? AdditionalPotentialOption_2 { get; set; }
    /// <summary>
    /// 에디셔널 잠재능력 세 번째 옵션
    /// </summary>
    public string? AdditionalPotentialOption_3 { get; set; }
    /// <summary>
    /// 착용 레벨 증가
    /// </summary>
    public long EquipmentLevelIncrease { get; set; }
    /// <summary>
    /// 장비 특별 옵션 정보
    /// </summary>
    public ItemExceptionalOption? ItemExceptionalOption { get; set; }
    /// <summary>
    /// 장비 추가 옵션 정보
    /// </summary>
    public ItemAddOption? ItemAddOption { get; set; }
    /// <summary>
    /// 성장 경험치
    /// </summary>
    public long GrowthExp { get; set; }
    /// <summary>
    /// 성장 레벨
    /// </summary>
    public long GrowthLevel { get; set; }
    /// <summary>
    /// 업그레이드 횟수
    /// </summary>
    public string? ScrollUpgrade { get; set; }
    /// <summary>
    /// 가위 사용 가능 횟수 (교환 불가 장비, 가위 횟수가 없는 교환 가능 장비는 255)
    /// </summary>
    public string? CuttableCount { get; set; }
    /// <summary>
    /// 황금 망치 재련 적용 (1: 적용, 이외 미적용)
    /// </summary>
    public string? GoldenHammerFlag { get; set; }
    /// <summary>
    /// 복구 가능 횟수
    /// </summary>
    public string? ScrollResilienceCount { get; set; }
    /// <summary>
    /// 업그레이드 가능 횟수
    /// </summary>
    public string? ScrollUpgradeableCount { get; set; }
    /// <summary>
    /// 소울 명
    /// </summary>
    public string? SoulName { get; set; }
    /// <summary>
    /// 소울 옵션
    /// </summary>
    public string? SoulOption { get; set; }
    /// <summary>
    /// 장비 기타 옵션 정보
    /// </summary>
    public ItemEtcOption? ItemEtcOption { get; set; }
    /// <summary>
    /// 강화 단계
    /// </summary>
    public string? Starforce { get; set; }
    /// <summary>
    /// 놀라운 장비 강화 주문서 사용 여부 (0: 미사용, 1: 사용)
    /// </summary>
    public string? StarforceScrollFlag { get; set; }
    /// <summary>
    /// 장비 스타포스 옵션 정보
    /// </summary>
    public ItemEtcOption? ItemStarforceOption { get; set; }
    /// <summary>
    /// 특수 반지 레벨
    /// </summary>
    public long SpecialRingLevel { get; set; }
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 장비 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}
