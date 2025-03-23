using UnityEngine;
public class UpgradeBalls : MonoBehaviour
{
    [SerializeField] private BallsFirstUpgrade _ballFirstUpgrade;
    [SerializeField] private BallsSecondUpgrade _ballsSecondUpgrade;
    private int _countFirstPoint;
    private int _countSecondPoint;
    [SerializeField] private UpgradeBallsUI _upgradeBallsUI;
    private void Start()
    {
        _countFirstPoint = PlayerPrefs.GetInt(_ballFirstUpgrade.ToString());
        _countSecondPoint = PlayerPrefs.GetInt(_ballsSecondUpgrade.ToString());
        if(_upgradeBallsUI != null)
        _upgradeBallsUI.UpdatePointUI(_countFirstPoint, _countSecondPoint);
    }
    public void FirstUpgrade()
    {
        _countFirstPoint = PlayerPrefs.GetInt(_ballFirstUpgrade.ToString());
        _countFirstPoint++;
        PlayerPrefs.SetInt(_ballFirstUpgrade.ToString(), _countFirstPoint);
        _upgradeBallsUI.UpdatePointUI(_countFirstPoint, _countSecondPoint);
        BallsMove.OnChangedStat();
    }
    public void SecondUpgrade()
    {
        _countSecondPoint = PlayerPrefs.GetInt(_ballsSecondUpgrade.ToString());
        _countSecondPoint++;
        PlayerPrefs.SetInt(_ballsSecondUpgrade.ToString(), _countSecondPoint);
        _upgradeBallsUI.UpdatePointUI(_countFirstPoint, _countSecondPoint);
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
