namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// Endpoints for character data.
/// </summary>
public interface ICharacterApi
{
    /// <summary>
    /// GET /maplestory/v1/id
    /// <para>
    /// Gets the identifier of a character (ocid).
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="characterName">The name of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<Character>> GetAsync(string characterName, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/basic
    /// <para>
    /// Gets the character's basic information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/basic
    /// <para>
    /// Gets the character's basic information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/popularity
    /// <para>
    /// Gets the character's popularity information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/popularity
    /// <para>
    /// Gets the character's popularity information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST) (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/stat
    /// <para>
    /// Gets the character's stat information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterStat>> GetStatAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/stat
    /// <para>
    /// Gets the character's stat information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterStat>> GetStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hyper-stat
    /// <para>
    /// Gets the character's hyper stat information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hyper-stat
    /// <para>
    /// Gets the character's hyper stat information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/propensity
    /// <para>
    /// Gets the character's propensity information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/propensity
    /// <para>
    /// Gets the character's propensity information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/ability
    /// <para>
    /// Gets the character's ability information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/ability
    /// <para>
    /// Gets the character's ability information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/item-equipment
    /// <para>
    /// Gets the character's item equipment information except cash equipment.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/item-equipment
    /// <para>
    /// Gets the character's item equipment information except cash equipment.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/cashitem-equipment
    /// <para>
    /// Gets the character's cash equipment information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/cashitem-equipment
    /// <para>
    /// Gets the character's cash equipment information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/symbol-equipment
    /// <para>
    /// Gets the character's equipped symbol information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/symbol-equipment
    /// <para>
    /// Gets the character's equipped symbol information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/set-effect
    /// <para>
    /// Gets the set effect information being applied to the character.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/set-effect
    /// <para>
    /// Gets the set effect information being applied to the character.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/beauty-equiment
    /// <para>
    /// Gets the character's hair, plastic surgery, and skin information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/beauty-equipment
    /// <para>
    /// Gets the character's hair, plastic surgery, and skin information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/android-equipment
    /// <para>
    /// Gets the android information the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/android-equipment
    /// <para>
    /// Gets the android information the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/pet-equipment
    /// <para>
    /// Gets the pet, pet skill, and equipment information the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/pet-equipment
    /// <para>
    /// Gets the pet, pet skill, and equipment information the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/skill
    /// <para>
    /// Gets the character's skill and hyper skill information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
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
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, string characterSkillGrade, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/skill
    /// <para>
    /// Gets the character's skill and hyper skill information.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
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
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, DateOnly date, string characterSkillGrade, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/link-skill
    /// <para>
    /// Gets the link skill information the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/link-skill
    /// <para>
    /// Gets the link skill information the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/vmatrix
    /// <para>
    /// Gets the information of the V Matrix slots and the V Cores the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/vmatrix
    /// <para>
    /// Gets the information of the V Matrix slots and the V Cores the character is equipped with.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hexamatrix
    /// <para>
    /// Gets the HEXA Cores information equipped with the HEXA Matrix.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hexamatrix
    /// <para>
    /// Gets the HEXA Cores information equipped with the HEXA Matrix.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hexamatrix-stat
    /// <para>
    /// Gets the HEXA stat information set to the HEXA Matrix.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hexamatrix-stat
    /// <para>
    /// Gets the HEXA stat information set to the HEXA Matrix.
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/dojang
    /// <para>
    /// Gets the record of Dojang (Mu Lung Dojo).
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/dojang
    /// <para>
    /// Gets the record of Dojang (Mu Lung Dojo).
    /// </para>
    /// <b>NOTE: Only the data after December 21, 2023 is available.</b>
    /// <para>
    /// The most up-to-date data will be retrieved if the date is not specified.
    /// </para>
    /// <para>
    /// From 1 AM (KST) every day, This API returns the data from a day ago, meaning if it's not past 1 AM (KST), it will return the data from 2 days ago.
    /// </para>
    /// <para>
    /// The ocid may change if the game contents are updated. Please be aware when using ocid-based services.
    /// </para>
    /// </summary>
    /// <param name="ocid">The ocid of the character.</param>
    /// <param name="date">The reference date (KST).</param>
    /// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
    /// <returns>The call result containing success, error, and data.</returns>
    Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, DateOnly date, CancellationToken cancellationToken = default);
}