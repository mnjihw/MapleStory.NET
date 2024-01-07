namespace MapleStory.NET.Objects.CharacterModels;
/// <summary>
/// 심볼 정보
/// </summary>
public class Symbol
{
    /// <summary>
    /// 심볼 명
    /// </summary>
    public string? SymbolName { get; set; }
    /// <summary>
    /// 심볼 아이콘 URL
    /// </summary>
    public string? SymbolIcon { get; set; }
    /// <summary>
    /// 심볼 설명
    /// </summary>
    public string? SymbolDescription { get; set; }
    /// <summary>
    /// 심볼로 인한 증가 수치
    /// </summary>
    public string? SymbolForce { get; set; }
    /// <summary>
    /// 심볼 레벨
    /// </summary>
    public long SymbolLevel { get; set; }
    /// <summary>
    /// 심볼로 증가한 힘
    /// </summary>
    public string? SymbolStr { get; set; }
    /// <summary>
    /// 심볼로 증가한 민첩
    /// </summary>
    public string? SymbolDex { get; set; }
    /// <summary>
    /// 심볼로 증가한 지력
    /// </summary>
    public string? SymbolInt { get; set; }
    /// <summary>
    /// 심볼로 증가한 운
    /// </summary>
    public string? SymbolLuk { get; set; }
    /// <summary>
    /// 심볼로 증가한 체력
    /// </summary>
    public string? SymbolHp { get; set; }
    /// <summary>
    /// 현재 보유 성장치
    /// </summary>
    public long SymbolGrowthCount { get; set; }
    /// <summary>
    /// 성장 시 필요한 성장치
    /// </summary>
    public long SymbolRequireGrowthCount { get; set; }
}