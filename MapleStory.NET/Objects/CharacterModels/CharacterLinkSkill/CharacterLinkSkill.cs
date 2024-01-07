namespace MapleStory.NET.Objects.CharacterModels.CharacterLinkSkill;
/// <summary>
/// Character link skill.
/// </summary>
public class CharacterLinkSkill
{
    private DateTimeOffset? _date;
    /// <summary>
    /// Reference date (KST).
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// Character's class.
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// List of link skill details of a character.
    /// </summary>
    [JsonPropertyName("character_link_skill")]
    public List<CharacterLinkSkillDetails>? CharacterLinkSkillDetails { get; set; }
    /// <summary>
    /// Character-owned link skill.
    /// </summary>
    public CharacterOwnedLinkSkill? CharacterOwnedLinkSkill { get; set; }
}