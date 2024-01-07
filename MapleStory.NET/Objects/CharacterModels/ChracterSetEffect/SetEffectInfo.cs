namespace MapleStory.NET.Objects.CharacterModels.CharacterSetEffect;
/// <summary>
/// 세트 효과 정보
/// </summary>
public class SetEffectInfo
{
    /// <summary>
    /// 세트 효과 레벨 (장비 수)
    /// </summary>
    public long SetCount { get; set; }
    /// <summary>
    /// 적용 중인 세트 효과 
    /// </summary>
    public string? SetOption { get; set; }
}