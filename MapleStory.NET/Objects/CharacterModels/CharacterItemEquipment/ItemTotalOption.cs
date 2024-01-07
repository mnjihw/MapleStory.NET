namespace MapleStory.NET.Objects.CharacterModels.CharacterItemEquipment;
/// <summary>
/// 장비 최종 옵션 정보
/// </summary>
public class ItemTotalOption
{
    /// <summary>
    /// STR
    /// </summary>
    public string? Str { get; set; }
    /// <summary>
    /// DEX
    /// </summary>
    public string? Dex { get; set; }
    /// <summary>
    /// INT
    /// </summary>
    public string? Int { get; set; }
    /// <summary>
    /// LUK
    /// </summary>
    public string? Luk { get; set; }
    /// <summary>
    /// 최대 HP
    /// </summary>
    public string? MaxHp { get; set; }
    /// <summary>
    /// 최대 MP
    /// </summary>
    public string? MaxMp { get; set; }
    /// <summary>
    /// 공격력
    /// </summary>
    public string? AttackPower { get; set; }
    /// <summary>
    /// 마력
    /// </summary>
    public string? MagicPower { get; set; }
    /// <summary>
    /// 방어력
    /// </summary>
    public string? Armor { get; set; }
    /// <summary>
    /// 이동속도
    /// </summary>
    public string? Speed { get; set; }
    /// <summary>
    /// 점프력
    /// </summary>
    public string? Jump { get; set; }
    /// <summary>
    /// 보스 공격 시 데미지 증가 (%)
    /// </summary>
    public string? BossDamage { get; set; }
    /// <summary>
    /// 몬스터 방어율 무시 (%)
    /// </summary>
    public string? IgnoreMonsterArmor { get; set; }
    /// <summary>
    /// 올스탯 (%)
    /// </summary>
    public string? AllStat { get; set; }
    /// <summary>
    /// 데미지 (%)
    /// </summary>
    public string? Damage { get; set; }
    /// <summary>
    /// 착용 레벨 감소
    /// </summary>
    public long? EquipmentLevelDecrease { get; set; }
    /// <summary>
    /// 최대 HP (%)
    /// </summary>
    public string? MaxHpRate { get; set; }
    /// <summary>
    /// 최대 MP (%)
    /// </summary>
    public string? MaxMpRate { get; set; }
}