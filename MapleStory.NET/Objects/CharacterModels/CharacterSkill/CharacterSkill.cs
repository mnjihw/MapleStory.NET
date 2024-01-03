namespace MapleStory.NET.Objects.CharacterModels.CharacterSkill;
public class CharacterSkill
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public string? CharacterSkillGrade { get; set; }
    [JsonPropertyName("character_skill")]
    public List<CharacterSkillDetails>? CharacterSkillDetails { get; set; }
}