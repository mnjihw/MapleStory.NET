namespace MapleStory.NET.Objects.CharacterModels.CharacterBeautyEquipment;
/// <summary>
/// 추가 캐릭터 성형 정보
/// </summary>
public class AdditionalCharacterFace
{
    /// <summary>
    /// 성형 명
    /// </summary>
    public string? FaceName { get; set; }
    /// <summary>
    /// 성형 베이스 컬러
    /// </summary>
    public string? BaseColor { get; set; }
    /// <summary>
    /// 성형 믹스 컬러
    /// </summary>
    public string? MixColor { get; set; }
    /// <summary>
    /// 성형 믹스 컬러의 염색 비율
    /// </summary>
    public string? MixRate { get; set; }
}