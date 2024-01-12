namespace MapleStory.NET.Objects.HistoryModels;

/// <summary>
/// 큐브 히스토리
/// </summary>
/// <param name="Count"> 결과 건수 </param>
/// <param name="NextCursor"> 페이징 처리를 위한 cursor </param>
/// <param name="CubeHistoryDetails"> 큐브 히스토리 세부정보 리스트 </param>
public record CubeHistory(int Count, string? NextCursor, [property: JsonPropertyName("cube_history")] List<CubeHistoryDetails>? CubeHistoryDetails);

/// <summary>
/// 큐브 히스토리 세부정보
/// </summary>
/// <param name="Id"> 큐브 히스토리 식별자 </param>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="CubeType"> 사용 큐브 </param>
/// <param name="ItemUpgradeResult"> 사영 결과 </param>
/// <param name="MiracleTimeFlag"> 미라클 타임 적용 여부 </param>
/// <param name="ItemEquipmentPart"> 장비 분류 </param>
/// <param name="ItemLevel"> 장비 레벨 </param>
/// <param name="TargetItem"> 큐브 사용한 장비 </param>
/// <param name="PotentialOptionGrade"> 잠재능력 등급 </param>
/// <param name="AdditionalPotentialOptionGrade"> 에디셔널 잠재능력 등급 </param>
/// <param name="UpgradeGuarantee"> 천장에 도달하여 확정 등급 상승한 여부 </param>
/// <param name="UpgradeGuaranteeCount"> 현재까지 쌓은 스택 </param>
/// <param name="BeforePotentialOption"> 사용 전 잠재능력 옵션 리스트 </param>
/// <param name="BeforeAdditionalPotentialOption"> 사용 전 에디셔널 잠재능력 옵션 리스트 </param>
/// <param name="AfterPotentialOption"> 사용 후 잠재능력 옵션 리스트 </param>
/// <param name="AfterAdditionalPotentialOption"> 사용 후 에디셔널 잠재능력 옵션 리스트 </param>
public record CubeHistoryDetails(string? Id, string? CharacterName, string? CubeType, string? ItemUpgradeResult, string? MiracleTimeFlag, string? ItemEquipmentPart, int ItemLevel, string? TargetItem, string? PotentialOptionGrade, string? AdditionalPotentialOptionGrade, bool UpgradeGuarantee, int UpgradeGuaranteeCount, List<PotentialOption>? BeforePotentialOption, List<PotentialOption>? BeforeAdditionalPotentialOption, List<PotentialOption>? AfterPotentialOption, List<PotentialOption>? AfterAdditionalPotentialOption)
{
    private DateTimeOffset? _dateCreate;
    /// <summary>
    /// 사용 일시 (KST)
    /// </summary>
    public DateTimeOffset? DateCreate
    {
        get => _dateCreate?.ToOffset(TimeSpan.FromHours(9));
        set => _dateCreate = value;
    }
}

/// <summary>
/// 잠재능력 옵션
/// </summary>
/// <param name="Value"> 옵션 명 </param>
/// <param name="Grade"> 옵션 등급 </param>
public record PotentialOption(string? Value, string? Grade);