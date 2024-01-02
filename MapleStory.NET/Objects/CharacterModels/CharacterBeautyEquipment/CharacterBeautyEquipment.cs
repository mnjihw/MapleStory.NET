namespace MapleStory.NET.Objects.CharacterModels.CharacterBeautyEquipment;
public class CharacterBeautyEquipment
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterGender { get; set; }
    public string? CharacterClass { get; set; }
    public CharacterHair? CharacterHair { get; set; }
    public CharacterFace? CharacterFace { get; set; }
    public string? CharacterSkinName { get; set; }
    public AdditionalCharacterHair? AdditionalCharacterHair { get; set; }
    public AdditionalCharacterFace? AdditionalCharacterFace { get; set; }
    public string? AdditionalCharacterSkinName { get; set; }
}