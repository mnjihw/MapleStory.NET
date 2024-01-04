namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// Endpoints for character data.
/// </summary>
public interface ICharacterApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/id
    /// <para>Gets the identifier (ocid) of a character based on its name.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<Character> object. If the operation is successful, 
    /// this object will contain the Character data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<Character>> GetAsync(string characterName, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/basic
    /// <para>Gets the basic information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterBasic> object. If the operation is successful, 
    /// this object contains the CharacterBasic data. If the operation fails, it contains an Error detailing the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/basic
    /// <para>Gets the basic information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterBasic> object. If the operation is successful, 
    /// this object contains the CharacterBasic data. If the operation fails, it contains an Error detailing the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/popularity
    /// <para>Gets the popularity information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterPopularity> object. If the operation is successful, 
    /// this object will contain the CharacterPopularity data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/popularity
    /// <para>Gets the popularity information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterPopularity> object. If the operation is successful, 
    /// this object will contain the CharacterPopularity data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/stat
    /// <para>Gets the stat information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterStat> object. If the operation is successful, 
    /// this object will contain the CharacterStat data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterStat>> GetStatAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/stat
    /// <para>Gets the stat information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterStat> object. If the operation is successful, 
    /// this object will contain the CharacterStat data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterStat>> GetStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hyper-stat
    /// <para>Gets the hyper stat information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterHyperStat> object. If the operation is successful, 
    /// this object will contain the CharacterHyperStat data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hyper-stat
    /// <para>Gets the hyper stat information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterHyperStat> object. If the operation is successful, 
    /// this object will contain the CharacterHyperStat data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/propensity
    /// <para>Gets the propensity information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterPropesity> object. If the operation is successful, 
    /// this object will contain the CharacterPropesity data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/propensity
    /// <para>Gets the propensity information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterPropesity> object. If the operation is successful, 
    /// this object will contain the CharacterPropesity data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/ability
    /// <para>Gets the ability information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterAbility> object. If the operation is successful, 
    /// this object will contain the CharacterAbility data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/ability
    /// <para>Gets the ability information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterAbility> object. If the operation is successful, 
    /// this object will contain the CharacterAbility data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/item-equipment
    /// <para>Gets the item equipment information of a character except cash equipment.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterItemEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterItemEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/item-equipment
    /// <para>Gets the item equipment information of a character except cash equipment.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterItemEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterItemEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/cashitem-equipment
    /// <para>Gets the cash equipment information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterCashItemEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterCashItemEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/cashitem-equipment
    /// <para>Gets the cash equipment information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterCashItemEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterCashItemEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/symbol-equipment
    /// <para>Gets the equipped symbol information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterSymbolEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterSymbolEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/symbol-equipment
    /// <para>Gets the equipped symbol information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterSymbolEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterSymbolEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/set-effect
    /// <para>Gets the set effect information being applied to a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterSetEffect> object. If the operation is successful, 
    /// this object will contain the CharacterSetEffect data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/set-effect
    /// <para>Gets the set effect information being applied to a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterSetEffect> object. If the operation is successful, 
    /// this object will contain the CharacterSetEffect data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/beauty-equiment
    /// <para>Gets the hair, plastic surgery, and skin information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterBeautyEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterBeautyEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/beauty-equipment
    /// <para>Gets the hair, plastic surgery, and skin information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterBeautyEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterBeautyEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/android-equipment
    /// <para>Gets the android information equipped with a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterAndroidEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterAndroidEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/android-equipment
    /// <para>Gets the android information equipped with a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterAndroidEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterAndroidEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/pet-equipment
    /// <para>Gets the pet, pet skill, and equipment information equipped with a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterPetEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterPetEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/pet-equipment
    /// <para>Gets the pet, pet skill, and equipment information equipped with a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterPetEquipment> object. If the operation is successful, 
    /// this object will contain the CharacterPetEquipment data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/skill
    /// <para>Gets the skill and hyper skill information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="characterSkillGrade">The skill grade of the class.
    /// <para>
    /// 0: 0th skills and Zero's public skills.
    /// </para>
    /// <para>
    /// 1: 1st skills.
    /// </para>
    /// <para>
    /// 1.5: 1.5th skills.
    /// </para>
    /// <para>
    /// 2: 2nd skills.
    /// </para>
    /// <para>
    /// 2.5: 2.5th skills.
    /// </para>
    /// <para>
    /// 3: 3rd skills.
    /// </para>
    /// <para>
    /// 4: 4th skills.
    /// </para>
    /// <para>
    /// hyperpassive: Hyper passive skills.
    /// </para>
    /// <para>
    /// hyperactive: Hyper active skills.
    /// </para>
    /// <para>
    /// 5: 5th skills.
    /// </para>
    /// <para>
    /// 6: 6th skills.
    /// </para>
    /// </param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterSkill> object. If the operation is successful, 
    /// this object will contain the CharacterSkill data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, string characterSkillGrade, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/skill
    /// <para>Gets the skill and hyper skill information of a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="characterSkillGrade">The skill grade of the class.
    /// <para>
    /// 0: 0th skills and Zero's public skills.
    /// </para>
    /// <para>
    /// 1: 1st skills.
    /// </para>
    /// <para>
    /// 1.5: 1.5th skills.
    /// </para>
    /// <para>
    /// 2: 2nd skills.
    /// </para>
    /// <para>
    /// 2.5: 2.5th skills.
    /// </para>
    /// <para>
    /// 3: 3rd skills.
    /// </para>
    /// <para>
    /// 4: 4th skills.
    /// </para>
    /// <para>
    /// hyperpassive: Hyper passive skills.
    /// </para>
    /// <para>
    /// hyperactive: Hyper active skills.
    /// </para>
    /// <para>
    /// 5: 5th skills.
    /// </para>
    /// <para>
    /// 6: 6th skills.
    /// </para>
    /// </param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterSkill> object. If the operation is successful, 
    /// this object will contain the CharacterSkill data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, DateOnly date, string characterSkillGrade, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/link-skill
    /// <para>Gets the link skill information equipped with a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterLinkSkill> object. If the operation is successful, 
    /// this object will contain the CharacterLinkSkill data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/link-skill
    /// <para>Gets the link skill information equipped with a character.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterLinkSkill> object. If the operation is successful, 
    /// this object will contain the CharacterLinkSkill data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/vmatrix
    /// <para>Gets the information of the V Matrix slots and the V Cores mounted.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterVMatrix> object. If the operation is successful, 
    /// this object will contain the CharacterVMatrix data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/vmatrix
    /// <para>Gets the information of the V Matrix slots and the V Cores mounted.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterVMatrix> object. If the operation is successful, 
    /// this object will contain the CharacterVMatrix data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hexamatrix
    /// <para>Gets the HEXA Cores information mounted on the HEXA Matrix.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterHexaMatrix> object. If the operation is successful, 
    /// this object will contain the CharacterHexaMatrix data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hexamatrix
    /// <para>Gets the HEXA Cores information mounted on the HEXA Matrix.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterHexaMatrix> object. If the operation is successful, 
    /// this object will contain the CharacterHexaMatrix data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hexamatrix-stat
    /// <para>Gets the HEXA stat information set to the HEXA Matrix.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterHexaMatrixStat> object. If the operation is successful, 
    /// this object will contain the CharacterHexaMatrixStat data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hexamatrix-stat
    /// <para>Gets the HEXA stat information set to the HEXA Matrix.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterHexaMatrixStat> object. If the operation is successful, 
    /// this object will contain the CharacterHexaMatrixStat data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/dojang
    /// <para>Gets the record of Dojang (Mu Lung Dojo).</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterDojang> object. If the operation is successful, 
    /// this object will contain the CharacterDojang data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/dojang
    /// <para>Gets the record of Dojang (Mu Lung Dojo).</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Updates daily at 1 AM (KST) with the previous day's data. If before 1 AM, returns data from two days prior.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">The unique ocid identifier of the character.</param>
    /// <param name="date">The reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>
    /// A task that, when completed, yields a CallResult<CharacterDojang> object. If the operation is successful, 
    /// this object will contain the CharacterDojang data. In case of failure, it will include an Error with details of the failure.
    /// The Success property of CallResult can be used to check if the call was successful.
    /// </returns>
    Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
}