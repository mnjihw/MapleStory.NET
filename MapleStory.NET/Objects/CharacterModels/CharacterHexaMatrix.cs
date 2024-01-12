namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 HEXA 코어 정보
/// </summary>
/// <param name="CharacterHexaCoreEquipment"> 캐릭터 HEXA 코어 정보 리스트 </param>
public record CharacterHexaMatrix(List<CharacterHexaCoreEquipment>? CharacterHexaCoreEquipment)
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
}

/// <summary>
/// HEXA 코어 정보
/// </summary>
/// <param name="HexaCoreName"> 코어 명 </param>
/// <param name="HexaCoreLevel"> 코어 레벨 </param>
/// <param name="HexaCoreType"> 코어 타입 </param>
/// <param name="LinkedSkill"> 연결된 스킬 리스트 </param>
public record CharacterHexaCoreEquipment(string? HexaCoreName, long HexaCoreLevel, string? HexaCoreType, List<LinkedSkill>? LinkedSkill);

/// <summary>
/// 연결된 스킬
/// </summary>
/// <param name="HexaSkillId"> HEXA 스킬 명 </param>
public record LinkedSkill(string? HexaSkillId);