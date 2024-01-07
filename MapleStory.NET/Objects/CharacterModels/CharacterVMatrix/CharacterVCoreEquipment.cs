namespace MapleStory.NET.Objects.CharacterModels.CharacterVMatrix;
/// <summary>
/// V 코어 정보
/// </summary>
public class CharacterVCoreEquipment
{
    /// <summary>
    /// 슬록 인덱스
    /// </summary>
    public string? SlotId { get; set; }
    /// <summary>
    /// 슬롯 레벨
    /// </summary>
    public long SlotLevel { get; set; }
    /// <summary>
    /// 코어 명
    /// </summary>
    public string? VCoreName { get; set; }
    /// <summary>
    /// 코어 타입
    /// </summary>
    public string? VCoreType { get; set; }
    /// <summary>
    /// 코어 레벨
    /// </summary>
    public long VCoreLevel { get; set; }
    /// <summary>
    /// 코어에 해당하는 스킬 명
    /// </summary>
    public string? VCoreSkill_1 { get; set; }
    /// <summary>
    /// (강화 코어인 경우) 코어에 해당하는 두 번째 스킬 명
    /// </summary>
    public string? VCoreSkill_2 { get; set; }
    /// <summary>
    /// (강화 코어인 경우) 코어에 해당하는 세 번째 스킬 명
    /// </summary>
    public string? VCoreSkill_3 { get; set; }
}