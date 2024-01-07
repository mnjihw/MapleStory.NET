namespace MapleStory.NET.Objects.CharacterModels.CharacterHyperStat;
/// <summary>
/// 하이퍼 스탯 프리셋 정보
/// </summary>
public class HyperStatPreset
{
    /// <summary>
    /// 스탯 종류
    /// </summary>
    public string? StatType { get; set; }
    /// <summary>
    /// 스탯 투자 포인트
    /// </summary>
    public long StatPoint { get; set; }
    /// <summary>
    /// 스탯 레벨
    /// </summary>
    public long StatLevel { get; set; }
    /// <summary>
    /// 스탯 상승량
    /// </summary>
    public string? StatIncrease { get; set; }
}