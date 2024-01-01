using System.Text.Json.Serialization;

namespace MapleStory.NET.Objects.HistoryModels.CubeHistory;
public class CubeHistory
{
    public int Count { get; set; }
    public string? NextCursor { get; set; }
    [JsonPropertyName("cube_history")]
    public List<CubeHistoryDetails>? CubeHistoryDetails { get; set; }
}