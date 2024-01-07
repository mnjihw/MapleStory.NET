namespace MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
/// <summary>
/// 프리셋 장착 캐시 장비 정보
/// </summary>
public class AdditionalCashItemEquipmentPreset
{
    /// <summary>
    /// 캐시 장비 부위 명
    /// </summary>
    public string? CashItemEquipmentPart { get; set; }
    /// <summary>
    /// 캐시 장비 슬롯 위치
    /// </summary>
    public string? CashItemEquipmentSlot { get; set; }
    /// <summary>
    /// 캐시 장비 명
    /// </summary>
    public string? CashItemName { get; set; }
    /// <summary>
    /// 캐시 장비 아이콘 URL
    /// </summary>
    public string? CashItemIcon { get; set; }
    /// <summary>
    /// 캐시 장비 설명
    /// </summary>
    public string? CashItemDescription { get; set; }
    /// <summary>
    /// 캐시 장비 옵션 리스트
    /// </summary>
    public List<CashItemOption>? CashItemOption { get; set; }
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 캐시 장비 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// 캐시 장비 옵션 유효 기간 (KST, 시간 단위 데이터로 분은 0 고정)
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
    /// <summary>
    /// 캐시 장비 라벨 정보
    /// </summary>
    public string? CashItemLabel { get; set; }
    /// <summary>
    /// 캐시 장비 컬러링프리즘 정보 리스트
    /// </summary>
    public List<CashItemColoringPrism>? CashItemColoringPrism { get; set; }
    /// <summary>
    /// 다른 프리셋에서 장비 추가 장착 없이 1번 프리셋의 장비 공유를 비활성화했는지 여부
    /// </summary>
    public string? BasePresetItemDisableFlag { get; set; }
}