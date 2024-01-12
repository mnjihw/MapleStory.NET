namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 장착 심볼 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="Symbol"> 심볼 정보 리스트 </param>
public record CharacterSymbolEquipment(string? CharacterClass, List<Symbol>? Symbol)
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
/// 심볼 정보
/// </summary>
/// <param name="SymbolName"> 심볼 명 </param>
/// <param name="SymbolIcon"> 심볼 아이콘 URL </param>
/// <param name="SymbolDescription"> 심볼 설명 </param>
/// <param name="SymbolForce"> 심볼로 인한 증가 수치 </param>
/// <param name="SymbolLevel"> 심볼 레벨 </param>
/// <param name="SymbolStr"> 심볼로 증가한 힘 </param>
/// <param name="SymbolDex"> 심볼로 증가한 민첩 </param>
/// <param name="SymbolInt"> 심볼로 증가한 지력 </param>
/// <param name="SymbolLuk"> 심볼로 증가한 운 </param>
/// <param name="SymbolHp"> 심볼로 증가한 체력 </param>
/// <param name="SymbolGrowthCount"> 현재 보유 성장치 </param>
/// <param name="SymbolRequireGrowthCount"> 성장 시 필요한 성장치 </param>
public record Symbol(string? SymbolName, string? SymbolIcon, string? SymbolDescription, string? SymbolForce, long SymbolLevel, string? SymbolStr, string? SymbolDex, string? SymbolInt, string? SymbolLuk, string? SymbolHp, long SymbolGrowthCount, long SymbolRequireGrowthCount);