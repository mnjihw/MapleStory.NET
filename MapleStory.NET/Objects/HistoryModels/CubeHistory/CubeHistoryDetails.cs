namespace MapleStory.NET.Objects.HistoryModels.CubeHistory;
public class CubeHistoryDetails
{
    public string? Id { get; set; }
    public string? CharacterName { get; set; }
    private DateTimeOffset? _dateCreate;
    public DateTimeOffset? DateCreate
    {
        get => _dateCreate?.ToOffset(TimeSpan.FromHours(9));
        set => _dateCreate = value;
    }
    public string? CubeType { get; set; }
    public string? ItemUpgradeResult { get; set; }
    public string? MiracleTimeFlag { get; set; }
    public string? ItemEquipmentPart { get; set; }
    public int ItemLevel { get; set; }
    public string? TargetItem { get; set; }
    public string? PotentialOptionGrade { get; set; }
    public string? AdditionalPotentialOptionGrade { get; set; }
    public bool UpgradeGuarantee { get; set; }
    public int UpgradeGuaranteeCount { get; set; }
    public List<PotentialOption>? BeforePotentialOption { get; set; }
    public List<PotentialOption>? BeforeAdditionalPotentialOption { get; set; }
    public List<PotentialOption>? AfterPotentialOption { get; set; }
    public List<PotentialOption>? AfterAdditionalPotentialOption { get; set; }
}