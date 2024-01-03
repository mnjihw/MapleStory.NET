namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrix;
public class CharacterHexaCoreEquipment
{
    public string? HexaCoreName { get; set; }
    public long HexaCoreLevel { get; set; }
    public string? HexaCoreType { get; set; }
    public List<LinkedSkill>? LinkedSkill { get; set; }
}