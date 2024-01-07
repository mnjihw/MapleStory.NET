namespace MapleStory.NET.Objects.GuildModels.GuildBasic;
/// <summary>
/// 길드 노블레스 스킬
/// </summary>
public class GuildNoblesseSkill
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
    /// 스킬 레벨별 효과
    /// </summary>
    public string? SkillEffect { get; set; }
    /// <summary>
    /// 스킬 아이콘 URL
    /// </summary>
    public string? SkillIcon { get; set; }
}
