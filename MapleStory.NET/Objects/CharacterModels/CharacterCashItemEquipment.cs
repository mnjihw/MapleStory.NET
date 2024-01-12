namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 장착 캐시 장비 정보
/// </summary>
/// <param name="CharacterGender"> 캐릭터 성별 </param>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="PresetNo"> 적용 중인 캐시 장비 프리셋 번호 </param>
/// <param name="CashItemEquipmentPreset_1"> 1번 프리셋 장착 캐시 장비 정보 리스트 </param>
/// <param name="CashItemEquipmentPreset_2"> 2번 프리셋 장착 캐시 장비 정보 리스트 </param>
/// <param name="CashItemEquipmentPreset_3"> 3번 프리셋 장착 캐시 장비 정보 리스트 </param>
/// <param name="AdditionalCashItemEquipmentPreset_1"> 제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드의 1번 프리셋 장착 캐시 장비 정보 리스트 </param>
/// <param name="AdditionalCashItemEquipmentPreset_2"> 제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드의 2번 프리셋 장착 캐시 장비 정보 리스트 </param>
/// <param name="AdditionalCashItemEquipmentPreset_3"> 제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드의 3번 프리셋 장착 캐시 장비 정보 리스트 </param>
public record CharacterCashItemEquipment(string CharacterGender, string CharacterClass, long? PresetNo, List<CashItemEquipmentPreset> CashItemEquipmentPreset_1, List<CashItemEquipmentPreset> CashItemEquipmentPreset_2, List<CashItemEquipmentPreset> CashItemEquipmentPreset_3, List<AdditionalCashItemEquipmentPreset> AdditionalCashItemEquipmentPreset_1, List<AdditionalCashItemEquipmentPreset> AdditionalCashItemEquipmentPreset_2, List<AdditionalCashItemEquipmentPreset> AdditionalCashItemEquipmentPreset_3)
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
}

/// <summary>
/// 캐시 장비 옵션
/// </summary>
/// <param name="OptionType"> 옵션 타입 </param>
/// <param name="OptionValue"> 옵션 값 </param>
public record CashItemOption(string OptionType, string OptionValue);

/// <summary>
/// 캐시 장비 프리셋 정보
/// </summary>
/// <param name="CashItemEquipmentPart"> 캐시 장비 부위 명 </param>
/// <param name="CashItemEquipmentSlot"> 캐시 장비 슬롯 위치 </param>
/// <param name="CashItemName"> 캐시 장비 명 </param>
/// <param name="CashItemIcon"> 캐시 장비 아이콘 URL </param>
/// <param name="CashItemDescription"> 캐시 장비 설명 </param>
/// <param name="CashItemOption"> 캐시 장비 옵션 리스트 </param>
/// <param name="CashItemLabel"> 캐시 장비 라벨 정보 </param>
/// <param name="CashItemColoringPrism"> 캐시 장비 컬러링프리즘 정보 </param>
/// <param name="BasePresetItemDisableFlag"> 다른 프리셋에서 장비 추가 장착 없이 1번 프리셋의 장비 공유를 비활성화 했는지 여부 </param>
public record CashItemEquipmentPreset(string CashItemEquipmentPart, string CashItemEquipmentSlot, string CashItemName, string CashItemIcon, string CashItemDescription, List<CashItemOption> CashItemOption, string CashItemLabel, CashItemColoringPrism CashItemColoringPrism, string BasePresetItemDisableFlag)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 캐시 장비 유효 기간 (KST).
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// 캐시 장비 옵션 유효 기간 (KST, 시간 단위 데이터로 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
}

/// <summary>
/// 프리셋 장착 캐시 장비 정보
/// </summary>
/// <param name="CashItemEquipmentPart"> 캐시 장비 부위 명 </param>
/// <param name="CashItemEquipmentSlot"> 캐시 장비 슬롯 위치 </param>
/// <param name="CashItemName"> 캐시 장비 명 </param>
/// <param name="CashItemIcon"> 캐시 장비 아이콘 URL </param>
/// <param name="CashItemDescription"> 캐시 장비 설명 </param>
/// <param name="CashItemOption"> 캐시 장비 옵션 리스트 </param>
/// <param name="CashItemLabel"> 캐시 장비 라벨 정보 </param>
/// <param name="CashItemColoringPrism"> 캐시 장비 컬러링프리즘 정보 </param>
/// <param name="BasePresetItemDisableFlag"> 다른 프리셋에서 장비 추가 장착 없이 1번 프리셋의 장비 공유를 비활성화했는지 여부 </param>
public record AdditionalCashItemEquipmentPreset(string CashItemEquipmentPart, string CashItemEquipmentSlot, string CashItemName, string CashItemIcon, string CashItemDescription, List<CashItemOption> CashItemOption, string CashItemLabel, CashItemColoringPrism CashItemColoringPrism, string BasePresetItemDisableFlag)
{
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
}

/// <summary>
/// 캐시 장비 컬러링프리즘 세부정보
/// </summary>
/// <param name="ColorRange"> 컬러링프리즘 색상 범위 </param>
/// <param name="Hue"> 컬러링프리즘 색조 </param>
/// <param name="Saturation"> 컬러링프리즘 채도 </param>
/// <param name="Value"> 컬러링프리즘 명도 </param>
public record CashItemColoringPrism(string ColorRange, long? Hue, long? Saturation, long? Value);