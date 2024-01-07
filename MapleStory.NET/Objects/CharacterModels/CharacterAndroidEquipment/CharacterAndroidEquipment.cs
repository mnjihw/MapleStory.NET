namespace MapleStory.NET.Objects.CharacterModels.CharacterAndroidEquipment;
/// <summary>
/// 장착 안드로이드 정보
/// </summary>
public class CharacterAndroidEquipment
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
    /// 안드로이드 명
    /// </summary>
    public string? AndroidName { get; set; }
    /// <summary>
    /// 안드로이드 닉네임
    /// </summary>
    public string? AndroidNickname { get; set; }
    /// <summary>
    /// 안드로이드 아이콘 URL
    /// </summary>
    public string? AndroidIcon { get; set; }
    /// <summary>
    /// 안드로이드 설명
    /// </summary>
    public string? AndroidDescription { get; set; }
    /// <summary>
    /// 안드로이드 헤어 정보
    /// </summary>
    public AndroidHair? AndroidHair { get; set; }
    /// <summary>
    /// 안드로이드 성형 정보
    /// </summary>
    public AndroidFace? AndroidFace { get; set; }
    /// <summary>
    /// 안드로이드 피부 명
    /// </summary>
    public string? AndroidSkinName { get; set; }
    /// <summary>
    /// 안드로이드 캐시 아이템 장착 정보 리스트
    /// </summary>
    public List<AndroidCashItemEquipment>? AndroidCashItemEquipment { get; set; }
    /// <summary>
    /// 안드로이드 이어센서 클립 적용 여부
    /// </summary>
    public string? AndroidEarSensorClipFlag { get; set; }
}