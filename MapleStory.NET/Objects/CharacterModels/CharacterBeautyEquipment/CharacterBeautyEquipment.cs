namespace MapleStory.NET.Objects.CharacterModels.CharacterBeautyEquipment;
/// <summary>
/// 캐릭터 장착 헤어, 성형, 피부 정보
/// </summary>
public class CharacterBeautyEquipment
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    /// <summary>
    /// 캐릭터 성별
    /// </summary>
    public string? CharacterGender { get; set; }
    /// <summary>
    /// 캐릭터 직업
    /// </summary>
    public string? CharacterClass { get; set; }
    /// <summary>
    /// 캐릭터 헤어 정보 (제로인 경우 알파, 엔젤릭버스터인 경우 일반 모드)
    /// </summary>
    public CharacterHair? CharacterHair { get; set; }
    /// <summary>
    /// 캐릭터 성형 정보 (제로인 경우 알파, 엔젤릭버스터인 경우 일반 모드)
    /// </summary>
    public CharacterFace? CharacterFace { get; set; }
    /// <summary>
    /// 피부 명 (제로인 경우 알파, 엔젤릭버스터인 경우 일반 모드)
    /// </summary>
    public string? CharacterSkinName { get; set; }
    /// <summary>
    /// 추가 캐릭터 헤어 정보 (제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드에 적용 중인 헤어 정보)
    /// </summary>
    public AdditionalCharacterHair? AdditionalCharacterHair { get; set; }
    /// <summary>
    /// 추가 캐릭터 성형 정보 (제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드에 적용 중인 성형 정보)
    /// </summary>
    public AdditionalCharacterFace? AdditionalCharacterFace { get; set; }
    /// <summary>
    /// 추가 피부 명 (제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드에 적용 중인 피부 명)
    /// </summary>
    public string? AdditionalCharacterSkinName { get; set; }
}