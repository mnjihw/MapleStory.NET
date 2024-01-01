using MapleStory.NET.Interfaces.Api;
using MapleStory.NET.Objects.CharacterModels.Character;
using MapleStory.NET.Objects.CharacterModels.CharacterBasic;
using MapleStory.NET.Objects.CharacterModels.CharacterHyperStat;
using MapleStory.NET.Objects.CharacterModels.CharacterPopularity;
using MapleStory.NET.Objects.CharacterModels.CharacterStat;
using MapleStory.NET.Objects.CharacterModels.CharacterPropensity;
using MapleStory.NET.Objects.CharacterModels.CharacterAbility;
using MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
using MapleStory.NET.Objects.CharacterModels.CharacterCashItemEquipment;
using MapleStory.NET.Objects.CharacterModels.CharacterSymbolEquipment;
using MapleStory.NET.Objects.CharacterModels.CharacterSetEffect;
using MapleStory.NET.Objects.CharacterModels.CharacterBeautyEquipment;
using MapleStory.NET.Objects.CharacterModels.CharacterAndroidEquipment;
using MapleStory.NET.Objects.CharacterModels.CharacterPetEquipment;
using MapleStory.NET.Objects.CharacterModels.CharacterSkill;
using MapleStory.NET.Objects.CharacterModels.CharacterLinkSkill;
using MapleStory.NET.Objects.CharacterModels.CharacterVMatrix;
using MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrix;
using MapleStory.NET.Objects.CharacterModels.CharacterHexaMatrixStat;
using MapleStory.NET.Objects.CharacterModels.CharacterDojang;
using MapleStory.NET.Objects;
using Microsoft.Extensions.Logging;

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
    private static DateOnly LatestAvailableDate => Helper.GetLatestApiAvailableDate(ApiUpdateTime, 1);

    internal CharacterApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    public Task<CallResult<Character>> GetAsync(string characterName, CancellationToken ct = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(characterName);
        var parameters = new Dictionary<string, string> { ["character_name"] = characterName };
        return GetAsync<Character>("/maplestory/v1/id", parameters, ct);
    }
    public Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, CancellationToken ct = default) => GetBasicAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterBasic>(BasicEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, CancellationToken ct = default) => GetPopularityAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterPopularity>(PopularityEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterStat>> GetStatAsync(string ocid, CancellationToken ct = default) => GetStatAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterStat>> GetStatAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterStat>(StatEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, CancellationToken ct = default) => GetHyperStatAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterHyperStat>(HyperStatEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, CancellationToken ct = default) => GetPropensityAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterPropesity>(PropensityEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, CancellationToken ct = default) => GetAbilityAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterAbility>(AbilityEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, CancellationToken ct = default) => GetItemEquipmentAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterItemEquipment>(ItemEquipmentEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, CancellationToken ct = default) => GetCashItemEquipmentAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterCashItemEquipment>(CashItemEquipmentEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, CancellationToken ct = default) => GetSymbolEquipmentAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterSymbolEquipment>(SymbolEquipmentEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, CancellationToken ct = default) => GetSetEffectAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterSetEffect>(SetEffectEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, CancellationToken ct = default) => GetBeautyEquipmentAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterBeautyEquipment>(BeautyEquipmentEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, CancellationToken ct = default) => GetAndroidEquipmentAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterAndroidEquipment>(AndroidEquipmentEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, CancellationToken ct = default) => GetPetEquipmentAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterPetEquipment>(PetEquipmentEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, string characterSkillGrade, CancellationToken ct = default) => GetSkillAsync(ocid, LatestAvailableDate, characterSkillGrade, ct);
    public Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, DateOnly date, string characterSkillGrade, CancellationToken ct = default) => GetAsync<CharacterSkill>(SkillEndpoint, ocid, date, new() { ["character_skill_grade"] = characterSkillGrade }, ct);
    public Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, CancellationToken ct = default) => GetLinkSkillAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterLinkSkill>(LinkSkillEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, CancellationToken ct = default) => GetVMatrixAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterVMatrix>(VMatrixEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, CancellationToken ct = default) => GetHexaMatrixAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterHexaMatrix>(HexaMatrixEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, CancellationToken ct = default) => GetHexaMatrixStatAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterHexaMatrixStat>(HexaMatrixStatEndpoint, ocid, date, [], ct);
    public Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, CancellationToken ct = default) => GetDojangAsync(ocid, LatestAvailableDate, ct);
    public Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, DateOnly date, CancellationToken ct = default) => GetAsync<CharacterDojang>(DojangEndpoint, ocid, date, [], ct);
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
