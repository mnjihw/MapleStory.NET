namespace MapleStory.NET.Objects.CharacterModels.CharacterHyperStat;

public class CharacterHyperStat
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? CharacterClass { get; set; }
    public string? UsePresetNo { get; set; }
    public long UseAvailableHyperStat { get; set; }
    public List<HyperStatPreset>? HyperStatPreset_1 { get; set; }
    public long HyperStatPreset_1RemainPoint { get; set; }
    public List<HyperStatPreset>? HyperStatPreset_2 { get; set; }
    public long HyperStatPreset_2RemainPoint { get; set; }
    public List<HyperStatPreset>? HyperStatPreset_3 { get; set; }
    public long HyperStatPreset_3RemainPoint { get; set; }
}