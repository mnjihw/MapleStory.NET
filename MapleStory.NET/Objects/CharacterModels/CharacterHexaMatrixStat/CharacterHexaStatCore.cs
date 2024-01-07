namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrixStat;
/// <summary>
/// Character's HEXA stat core.
/// </summary>
public class CharacterHexaStatCore
{
    /// <summary>
    /// Slot index.
    /// </summary>
    public string? SlotId { get; set; }
    /// <summary>
    /// Main stat name.
    /// </summary>
    public string? MainStatName { get; set; }
    /// <summary>
    /// First sub stat stat name.
    /// </summary>
    public string? SubStatName_1 { get; set; }
    /// <summary>
    /// Second sub stat name.
    /// </summary>
    public string? SubStatName_2 { get; set; }
    /// <summary>
    /// Main stat level.
    /// </summary>
    public long MainStatLevel { get; set; }
    /// <summary>
    /// First sub stat level.
    /// </summary>
    public long SubStatLevel_1 { get; set; }
    /// <summary>
    /// Second sub stat level.
    /// </summary>
    public long SubStatLevel_2 { get; set; }
    /// <summary>
    /// Stat core grade.
    /// </summary>
    public long StatGrade { get; set; }
}