namespace MapleStory.NET.Objects.CharacterModels.CharacterHyperStat;
/// <summary>
/// Character's Hyper stat.
/// </summary>
public class CharacterHyperStat
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
    /// Preset number applied.
    /// </summary>
    public string? UsePresetNo { get; set; }
    /// <summary>
    /// Available Hyper stat points.
    /// </summary>
    public long UseAvailableHyperStat { get; set; }
    /// <summary>
    /// List of first preset Hyper stats.
    /// </summary>
    public List<HyperStatPreset>? HyperStatPreset_1 { get; set; }
    /// <summary>
    /// Remaining points of first preset Hyper stat.
    /// </summary>
    public long HyperStatPreset_1RemainPoint { get; set; }
    /// <summary>
    /// List of second preset Hyper stats.
    /// </summary>
    public List<HyperStatPreset>? HyperStatPreset_2 { get; set; }
    /// <summary>
    /// Remaining points of second preset Hyper stat.
    /// </summary>
    public long HyperStatPreset_2RemainPoint { get; set; }
    /// <summary>
    /// List of third preset Hyper stats.
    /// </summary>
    public List<HyperStatPreset>? HyperStatPreset_3 { get; set; }
    /// <summary>
    /// Remaining points of third preset Hyper stat.
    /// </summary>
    public long HyperStatPreset_3RemainPoint { get; set; }
}