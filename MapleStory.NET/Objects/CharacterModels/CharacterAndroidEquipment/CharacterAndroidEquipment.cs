namespace MapleStory.NET.Objects.CharacterModels.CharacterAndroidEquipment;
public class CharacterAndroidEquipment
{
    private DateTimeOffset? _date;
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    public string? AndroidName { get; set; }
    public string? AndroidNickname { get; set; }
    public string? AndroidIcon { get; set; }
    public string? AndroidDescription { get; set; }
    public AndroidHair? AndroidHair { get; set; }
    public AndroidFace? AndroidFace { get; set; }
    public string? AndroidSkinName { get; set; }
    public List<AndroidCashItemEquipment>? AndroidCashItemEquipment { get; set; }
    public string? AndroidEarSensorClipFlag { get; set; }
}