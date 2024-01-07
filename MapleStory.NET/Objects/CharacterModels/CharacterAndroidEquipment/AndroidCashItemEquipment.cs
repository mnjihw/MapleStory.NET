namespace MapleStory.NET.Objects.CharacterModels.CharacterAndroidEquipment;
/// <summary>
/// 안드로이드 캐시 아이템 장착 정보
/// </summary>
public class AndroidCashItemEquipment
{
    /// <summary>
    /// 안드로이드 캐시 아이템 부위 명
    /// </summary>
    public string? CashItemEquipmentPart { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 슬롯 위치
    /// </summary>
    public string? CashItemEquipmentSlot { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 명
    /// </summary>
    public string? CashItemName { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 아이콘 URL
    /// </summary>
    public string? CashItemIcon { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 설명
    /// </summary>
    public string? CashItemDescription { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 옵션 리스트
    /// </summary>
    public List<CashItemOption>? CashItemOption { get; set; }
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 안드로이드 캐시 아이템 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// 안드로이드 캐시 아이템 옵션 유효 기간 (KST, 시간 단위 데이터로 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
    /// <summary>
    /// 안드로이드 캐시 아이템 라벨 정보 (스페셜라벨, 레드라벨, 블랙라벨, 마스터라벨)
    /// </summary>
    public string? CashItemLabel { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 컬러링프리즘 정보
    /// </summary>
    public List<CashItemColoringPrism>? CashItemColoringPrism { get; set; }
}