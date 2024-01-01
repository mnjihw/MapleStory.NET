namespace MapleStory.NET.Objects.UnionModels.UnionRaider;
public class UnionBlock
{
    public string? BlockType { get; set; }
    public string? BlockClass { get; set; }
    public string? BlockLevel { get; set; }
    public BlockControlPoint? BlockControlPoint { get; set; }
    public List<BlockPosition>? BlockPosition { get; set; }
}
