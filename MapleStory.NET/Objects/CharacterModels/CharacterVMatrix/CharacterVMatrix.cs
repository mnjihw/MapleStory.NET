namespace MapleStory.NET.Objects.CharacterModels.CharacterVMatrix;
/// <summary>
/// 캐릭터 V 매트릭스 정보
/// </summary>
public class CharacterVMatrix
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// 캐릭터 직업
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// V 코어 정보 리스트
    /// </summary>
    public List<CharacterVCoreEquipment>? CharacterVCoreEquipment { get; set; }
    /// <summary>
    /// 캐릭터 잔여 매트릭스 강화 포인트
    /// </summary>
    public long CharacterVMatrixRemainSlotUpgradePoint { get; set; }
}