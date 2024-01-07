namespace MapleStory.NET.Objects.CharacterModels.CharacterLinkSkill;
/// <summary>
/// 내 링크 스킬 정보
/// </summary>
public class CharacterOwnedLinkSkill
{
    /// <summary>
    /// 스킬 명
    /// </summary>
    public string? SkillName { get; set; }
    /// <summary>
    /// 스킬 설명
    /// </summary>
    public string? SkillDescription { get; set; }
    /// <summary>
    /// 스킬 레벨
    /// </summary>
    public long SkillLevel { get; set; }
    /// <summary>
    /// 스킬 효과
    /// </summary>
    public string? SkillEffect { get; set; }
    /// <summary>
    /// 스킬 아이콘 URL
    /// </summary>
    public string? SkillIcon { get; set; }
}