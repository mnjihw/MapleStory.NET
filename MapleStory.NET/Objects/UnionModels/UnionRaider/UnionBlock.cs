namespace MapleStory.NET.Objects.UnionModels.UnionRaider;
/// <summary>
/// 유니온 블록 정보
/// </summary>
public class UnionBlock
{
    /// <summary>
    /// 블록 모양 (전사, 마법사, 궁수, 도적, 해적, 메이플m, 하이브리드)
    /// </summary>
    public string? BlockType { get; set; }
    /// <summary>
    /// 블록 해당 캐릭터 직업
    /// </summary>
    public string? BlockClass { get; set; }
    /// <summary>
    /// 블록 해당 캐릭터 레벨
    /// </summary>
    public string? BlockLevel { get; set; }
    /// <summary>
    /// 블록 기준점 좌표
    /// </summary>
    public BlockControlPoint? BlockControlPoint { get; set; }
    /// <summary>
    /// 블록이 차지하고 있는 영역 좌표들의 리스트(null: 미 배치 시)
    /// </summary>
    public List<BlockPosition>? BlockPosition { get; set; }
}
