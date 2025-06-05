using UnityEngine;
public class UpgradeBalls : MonoBehaviour
{
    [SerializeField] private BallsFirstUpgrade _ballFirstUpgrade;
    [SerializeField] private BallsSecondUpgrade _ballsSecondUpgrade;
    private int _countFirstPoint;
    public int PlusFirstPoint;
    private int _countSecondPoint;
    public int PlusSecondPoint;
    private UpgradeBallsUI _upgradeBallsUI;
    private void Start()
    {
        _upgradeBallsUI = GetComponent<UpgradeBallsUI>();
        _countFirstPoint = PlayerPrefs.GetInt(_ballFirstUpgrade.ToString());
        _countSecondPoint = PlayerPrefs.GetInt(_ballsSecondUpgrade.ToString());
        if(_upgradeBallsUI != null)
        _upgradeBallsUI.UpdatePointUI(_countFirstPoint, _countSecondPoint, 0);
    }
    public void FirstUpgrade()
    {
        _countFirstPoint = PlayerPrefs.GetInt(_ballFirstUpgrade.ToString());
        _countFirstPoint += PlusFirstPoint;
        PlayerPrefs.SetInt(_ballFirstUpgrade.ToString(), _countFirstPoint);
        _upgradeBallsUI.UpdatePointUI(_countFirstPoint, _countSecondPoint, 1);
        BallsMove.OnChangedStat();
    }
    public void SecondUpgrade()
    {
        _countSecondPoint = PlayerPrefs.GetInt(_ballsSecondUpgrade.ToString());
        _countSecondPoint += PlusSecondPoint;
        PlayerPrefs.SetInt(_ballsSecondUpgrade.ToString(), _countSecondPoint);
        _upgradeBallsUI.UpdatePointUI(_countFirstPoint, _countSecondPoint, 2);
        BallsDamage.OnChangedStat();
    }
    private enum BallsFirstUpgrade
    {
        RedFirstUpgrade,
        GreenFirstUpgrade,
        BlueFirstUpgrade
    }
    private enum BallsSecondUpgrade
    {
        RedSecondUpgrade,
        GreenSecondUpgrade,
        BlueSecondUpgrade
    }
}
