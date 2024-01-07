namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrixStat;
/// <summary>
/// Character's HEXA Matrix stat.
/// </summary>
public class CharacterHexaMatrixStat
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
    /// List of character's HEXA stat cores.
    /// </summary>
    public List<CharacterHexaStatCore>? CharacterHexaStatCore { get; set; }
    /// <summary>
    /// List of character's preset HEXA stat cores.
    /// </summary>
    public List<CharacterHexaStatCore>? PresetHexaStatCore { get; set; }
}