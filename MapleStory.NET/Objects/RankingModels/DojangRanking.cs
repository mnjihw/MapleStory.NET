namespace MapleStory.NET.Objects.RankingModels;

/// <summary>
/// 무릉도장 랭킹 정보
/// </summary>
/// <param name="Ranking"> 무릉도장 랭킹 세부정보 리스트 </param>
public record DojangRanking(List<DojangRankingDetails>? Ranking);

/// <summary>
/// 무릉도장 랭킹 세부정보
/// </summary>
/// <param name="Ranking"> 무릉도장 랭킹 순위 </param>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="ClassName"> 직업 명 </param>
/// <param name="SubClassName"> 전직 직업 명 </param>
/// <param name="CharacterLevel"> 캐릭터 레벨 </param>
/// <param name="DojangFloor"> 무릉도장 구간 </param>
/// <param name="DojangTimeRecord"> 무릉도장 클리어 시간 기록 (초 단위) </param>
public record DojangRankingDetails(int? Ranking, string? CharacterName, string? WorldName, string? ClassName, string? SubClassName, int? CharacterLevel, int? DojangFloor, int? DojangTimeRecord)
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
