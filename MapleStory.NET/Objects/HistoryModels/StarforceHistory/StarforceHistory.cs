namespace MapleStory.NET.Objects.HistoryModels.StarforceHistory;
public class StarforceHistory
{
    public int Count { get; set; }
    public string? NextCursor { get; set; }
    [JsonPropertyName("starforce_history")]
    public List<StarforceHistoryDetails>? StarforceHistoryDetails { get; set; }
}