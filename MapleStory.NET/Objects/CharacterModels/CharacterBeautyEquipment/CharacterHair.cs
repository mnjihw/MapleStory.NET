namespace MapleStory.NET.Objects.CharacterModels.CharacterBeautyEquipment;
/// <summary>
/// 캐릭터 헤어 정보
/// </summary>
public class CharacterHair
{
    /// <summary>
    /// 헤어 명
    /// </summary>
    public string? HairName { get; set; }
    /// <summary>
    /// 헤어 베이스 컬러
    /// </summary>
    public string? BaseColor { get; set; }
    /// <summary>
    /// 헤어 믹스 컬러
    /// </summary>
    public string? MixColor { get; set; }
    /// <summary>
    /// 헤어 믹스 컬러의 염색 비율
    /// </summary>
    public string? MixRate { get; set; }
}