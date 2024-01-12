namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 V 매트릭스 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="CharacterVCoreEquipment"> V 코어 정보 리스트 </param>
/// <param name="CharacterVMatrixRemainSlotUpgradePoint"> 캐릭터 잔여 매트릭스 강화 포인트 </param>
public record CharacterVMatrix(string CharacterClass, List<CharacterVCoreEquipment> CharacterVCoreEquipment, long? CharacterVMatrixRemainSlotUpgradePoint)
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
/// V 코어 정보
/// </summary>
/// <param name="SlotId"> 슬록 인덱스 </param>
/// <param name="SlotLevel"> 슬롯 레벨 </param>
/// <param name="VCoreName"> 코어 명 </param>
/// <param name="VCoreType"> 코어 타입 </param>
/// <param name="VCoreLevel"> 코어 레벨 </param>
/// <param name="VCoreSkill_1"> 코어에 해당하는 스킬 명 </param>
/// <param name="VCoreSkill_2"> (강화 코어인 경우) 코어에 해당하는 두 번째 스킬 명 </param>
/// <param name="VCoreSkill_3"> (강화 코어인 경우) 코어에 해당하는 세 번째 스킬 명 </param>
public record CharacterVCoreEquipment(string SlotId, long? SlotLevel, string VCoreName, string VCoreType, long? VCoreLevel, string VCoreSkill_1, string VCoreSkill_2, string VCoreSkill_3);