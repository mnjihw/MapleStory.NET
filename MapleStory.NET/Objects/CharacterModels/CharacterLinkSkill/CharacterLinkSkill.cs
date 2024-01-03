using System.Text.Json.Serialization;

namespace MapleStory.NET.Objects.CharacterModels.CharacterLinkSkill;
public class CharacterLinkSkill
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    [JsonPropertyName("character_link_skill")]
    public List<CharacterLinkSkillDetails>? CharacterLinkSkillDetails { get; set; }
    public CharacterOwnedLinkSkill? CharacterOwnedLinkSkill { get; set; }
}