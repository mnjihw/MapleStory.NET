namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 링크 스킬 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="CharacterLinkSkillDetails"> 링크 스킬 정보 리스트 </param>
/// <param name="CharacterOwnedLinkSkill"> 내 링크 스킬 정보 </param>
public record CharacterLinkSkill(string? CharacterClass, [property: JsonPropertyName("character_link_skill")] List<CharacterLinkSkillDetails>? CharacterLinkSkillDetails, CharacterOwnedLinkSkill? CharacterOwnedLinkSkill)
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
}

/// <summary>
/// 캐릭터 링크 스킬 세부정보
/// </summary>
/// <param name="SkillName"> 스킬 명 </param>
/// <param name="SkillDescription"> 스킬 설명 </param>
/// <param name="SkillLevel"> 스킬 레벨 </param>
/// <param name="SkillEffect"> 스킬 효과 </param>
/// <param name="SkillIcon"> 스킬 아이콘 URL </param>
public record CharacterLinkSkillDetails(string? SkillName, string? SkillDescription, long SkillLevel, string? SkillEffect, string? SkillIcon);

/// <summary>
/// 내 링크 스킬 정보
/// </summary>
/// <param name="SkillName"> 스킬 명 </param>
/// <param name="SkillDescription"> 스킬 설명 </param>
/// <param name="SkillLevel"> 스킬 레벨 </param>
/// <param name="SkillEffect"> 스킬 효과 </param>
/// <param name="SkillIcon"> 스킬 아이콘 URL </param>
public record CharacterOwnedLinkSkill(string? SkillName, string? SkillDescription, long SkillLevel, string? SkillEffect, string? SkillIcon);