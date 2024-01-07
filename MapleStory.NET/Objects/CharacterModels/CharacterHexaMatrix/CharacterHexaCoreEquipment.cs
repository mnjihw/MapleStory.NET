namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrix;
/// <summary>
/// HEXA 코어 정보
/// </summary>
public class CharacterHexaCoreEquipment
{
    /// <summary>
    /// 코어 명
    /// </summary>
    public string? HexaCoreName { get; set; }
    /// <summary>
    /// 코어 레벨
    /// </summary>
    public long HexaCoreLevel { get; set; }
    /// <summary>
    /// 코어 타입
    /// </summary>
    public string? HexaCoreType { get; set; }
    /// <summary>
    /// 연결된 스킬 리스트
    /// </summary>
    public List<LinkedSkill>? LinkedSkill { get; set; }
}