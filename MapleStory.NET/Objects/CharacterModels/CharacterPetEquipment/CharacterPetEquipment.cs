namespace MapleStory.NET.Objects.CharacterModels.CharacterPetEquipment;
public class CharacterPetEquipment
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? Pet_1Name { get; set; }
    public string? Pet_1Nickname { get; set; }
    public string? Pet_1Icon { get; set; }
    public string? Pet_1Description { get; set; }
    public PetEquipment? Pet_1Equipment { get; set; }
    public PetAutoSkill? Pet_1AutoSkill { get; set; }
    public string? Pet_1PetType { get; set; }
    public List<string>? Pet_1Skill { get; set; }
    public string? Pet_1DateExpire { get; set; }
    public string? Pet_2Name { get; set; }
    public string? Pet_2Nickname { get; set; }
    public string? Pet_2Icon { get; set; }
    public string? Pet_2Description { get; set; }
    public PetEquipment? Pet_2Equipment { get; set; }
    public PetAutoSkill? Pet_2AutoSkill { get; set; }
    public string? Pet_2PetType { get; set; }
    public List<string>? Pet_2Skill { get; set; }
    public string? Pet_2DateExpire { get; set; }
    public string? Pet_3Name { get; set; }
    public string? Pet_3Nickname { get; set; }
    public string? Pet_3Icon { get; set; }
    public string? Pet_3Description { get; set; }
    public PetEquipment? Pet_3Equipment { get; set; }
    public PetAutoSkill? Pet_3AutoSkill { get; set; }
    public string? Pet_3PetType { get; set; }
    public List<string>? Pet_3Skill { get; set; }
    public string? Pet_3DateExpire { get; set; }
}