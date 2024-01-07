namespace MapleStory.NET.Objects.UnionModels.UnionRaider;
/// <summary>
/// 블록 기준점 좌표.
/// <para>중앙 4칸 중 오른쪽 아래칸이 x: 0, y: 0 포지션</para>
/// <para>좌측으로 1칸씩 이동하면 x가 1씩 감소</para>
/// <para>우측으로 1칸씩 이동하면 x가 1씩 증가</para>
/// <para>아래로 1칸씩 이동하면 y가 1씩 감소</para>
/// <para>위로 1칸씩 이동하면 y가 1씩 증가</para>
/// </summary>
public class BlockControlPoint
{
    /// <summary>
    /// 블록 기준점 X좌표
    /// </summary>
    public long X { get; set; }
    /// <summary>
    /// 블록 기준점 Y좌표
    /// </summary>
    public long Y { get; set; }
}