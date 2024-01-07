namespace MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrix;
/// <summary>
/// 캐릭터 HEXA 코어 정보
/// </summary>
public class CharacterHexaMatrix
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
    /// 캐릭터 HEXA 코어 정보 리스트
    /// </summary>
    public List<CharacterHexaCoreEquipment>? CharacterHexaCoreEquipment { get; set; }
}