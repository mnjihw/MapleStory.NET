namespace MapleStory.NET.Objects.HistoryModels.StarforceHistory;
public class StarforceHistoryDetails
{
    public string? Id { get; set; }
    public string? ItemUpgradeResult { get; set; }
    public long BeforeStarforceCount { get; set; }
    public long AfterStarforceCount { get; set; }
    public string? StarcatchResult { get; set; }
    public string? SuperiorItemFlag { get; set; }
    public string? DestroyDefence { get; set; }
    public string? ChanceTime { get; set; }
    public string? EventFieldFlag { get; set; }
    public string? UpgradeItem { get; set; }
    public string? ProtectShield { get; set; }
    public string? BonusStatUpgrade { get; set; }
    public string? CharacterName { get; set; }
    public string? WorldName { get; set; }
    public string? TargetItem { get; set; }
    private DateTimeOffset? _dateCreate;
    public DateTimeOffset? DateCreate
    {
        get => _dateCreate?.ToOffset(TimeSpan.FromHours(9));
        set => _dateCreate = value;
    }
    public List<StarforceEventList>? StarforceEventList { get; set; }
}