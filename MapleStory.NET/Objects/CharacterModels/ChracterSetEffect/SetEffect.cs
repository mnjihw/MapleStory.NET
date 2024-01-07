namespace MapleStory.NET.Objects.CharacterModels.CharacterSetEffect;
/// <summary>
/// 세트 효과 정보
/// </summary>
public class SetEffect
{
    /// <summary>
    /// 세트 효과 명
    /// </summary>
    public string? SetName { get; set; }
    /// <summary>
    /// 세트 효과 개수 (럭키 아이템 포함))
    /// </summary>
    public long TotalSetCount { get; set; }
    /// <summary>
    /// 세트 효과 정보 리스트
    /// </summary>
    public List<SetEffectInfo>? SetEffectInfo { get; set; }
}