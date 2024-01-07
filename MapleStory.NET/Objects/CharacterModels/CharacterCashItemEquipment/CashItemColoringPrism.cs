namespace MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
/// <summary>
/// 캐시 장비 컬러링프리즘 정보
/// </summary>
public class CashItemColoringPrism
{
    /// <summary>
    /// 컬러링프리즘 색상 범위
    /// </summary>
    public string? ColorRange { get; set; }
    /// <summary>
    /// 컬러링프리즘 색조
    /// </summary>
    public long Hue { get; set; }
    /// <summary>
    /// 컬러링프리즘 채도
    /// </summary>
    public long Saturation { get; set; }
    /// <summary>
    /// 컬러링프리즘 명도
    /// </summary>
    public long Value { get; set; }
}