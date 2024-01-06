namespace MapleStory.NET.Api;

public class CharacterApi : BaseApi, ICharacterApi
{
    private const string ResourcePath = "/maplestory/v1/character";
    private const string BasicEndpoint = "basic";
    private const string PopularityEndpoint = "popularity";
    private const string StatEndpoint = "stat";
    private const string HyperStatEndpoint = "hyper-stat";
    private const string PropensityEndpoint = "propensity";
    private const string AbilityEndpoint = "ability";
    private const string ItemEquipmentEndpoint = "item-equipment";
    private const string CashItemEquipmentEndpoint = "cashitem-equipment";
    private const string SymbolEquipmentEndpoint = "symbol-equipment";
    private const string SetEffectEndpoint = "set-effect";
    private const string BeautyEquipmentEndpoint = "beauty-equipment";
    private const string AndroidEquipmentEndpoint = "android-equipment";
    private const string PetEquipmentEndpoint = "pet-equipment";
    private const string SkillEndpoint = "skill";
    private const string LinkSkillEndpoint = "link-skill";
    private const string VMatrixEndpoint = "vmatrix";
    private const string HexaMatrixEndpoint = "hexamatrix";
    private const string HexaMatrixStatEndpoint = "hexamatrix-stat";
    private const string DojangEndpoint = "dojang";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);
    private static TimeSpan ApiUpdateTime => new(1, 0, 0);
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 1, DateTimeOffset.UtcNow);

    internal CharacterApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    /// <inheritdoc />
    public Task<CallResult<Character>> GetAsync(string characterName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(characterName);
        var parameters = new Dictionary<string, string> { ["character_name"] = characterName };
        return GetAsync<Character>("/maplestory/v1/id", parameters, cancellationToken);
    }
    /// <inheritdoc />
    public Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, CancellationToken cancellationToken = default) => GetBasicAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterBasic>(BasicEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, CancellationToken cancellationToken = default) => GetPopularityAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterPopularity>(PopularityEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterStat>> GetStatAsync(string ocid, CancellationToken cancellationToken = default) => GetStatAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterStat>> GetStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterStat>(StatEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, CancellationToken cancellationToken = default) => GetHyperStatAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterHyperStat>(HyperStatEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, CancellationToken cancellationToken = default) => GetPropensityAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterPropesity>(PropensityEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, CancellationToken cancellationToken = default) => GetAbilityAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterAbility>(AbilityEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, CancellationToken cancellationToken = default) => GetItemEquipmentAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterItemEquipment>(ItemEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, CancellationToken cancellationToken = default) => GetCashItemEquipmentAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterCashItemEquipment>(CashItemEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, CancellationToken cancellationToken = default) => GetSymbolEquipmentAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterSymbolEquipment>(SymbolEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, CancellationToken cancellationToken = default) => GetSetEffectAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterSetEffect>(SetEffectEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, CancellationToken cancellationToken = default) => GetBeautyEquipmentAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterBeautyEquipment>(BeautyEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, CancellationToken cancellationToken = default) => GetAndroidEquipmentAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterAndroidEquipment>(AndroidEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, CancellationToken cancellationToken = default) => GetPetEquipmentAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterPetEquipment>(PetEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, string characterSkillGrade, CancellationToken cancellationToken = default) => GetSkillAsync(ocid, LatestAvailableDate, characterSkillGrade, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, DateOnly date, string characterSkillGrade, CancellationToken cancellationToken = default) => GetAsync<CharacterSkill>(SkillEndpoint, ocid, date, new() { ["character_skill_grade"] = characterSkillGrade }, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, CancellationToken cancellationToken = default) => GetLinkSkillAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterLinkSkill>(LinkSkillEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, CancellationToken cancellationToken = default) => GetVMatrixAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterVMatrix>(VMatrixEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, CancellationToken cancellationToken = default) => GetHexaMatrixAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterHexaMatrix>(HexaMatrixEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, CancellationToken cancellationToken = default) => GetHexaMatrixStatAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterHexaMatrixStat>(HexaMatrixStatEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, CancellationToken cancellationToken = default) => GetDojangAsync(ocid, LatestAvailableDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default) => GetAsync<CharacterDojang>(DojangEndpoint, ocid, date, [], cancellationToken);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, string ocid, DateOnly date, Dictionary<string, string> parameters, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(ocid);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);

        parameters["ocid"] = ocid;
        parameters["date"] = date.ToString("yyyy-MM-dd");

        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }
}
