using TMPro;
using UnityEngine;
public class UpgradeBallsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _firstUpgrade;
    [SerializeField] private TextMeshProUGUI _secondUpgrade;
    [SerializeField] private TextMeshProUGUI _priseFirstUpgrade;
    [SerializeField] private TextMeshProUGUI _priseSecondUpgrade;
    [SerializeField] private BuyUpgrade _buyUpgradeFirst;
    [SerializeField] private BuyUpgrade _buyUpgradeSecond;
    [SerializeField] private UpgradeBalls _upgradeBalls;
    private int _countLvl;
    public void UpdatePointUI(int countFirstPoint, int countSecondPoint)
    {
        _countLvl++;
        _priseFirstUpgrade.text = $"${_buyUpgradeFirst.Prise}";
        _priseSecondUpgrade.text = $"${_buyUpgradeSecond.Prise}";
        _firstUpgrade.text = $"{countFirstPoint} >> {countFirstPoint + _upgradeBalls.PlusFirstPoint}";
        _secondUpgrade.text = $"{countSecondPoint} >> {countSecondPoint + _upgradeBalls.PlusSecondPoint}";
        if (_countLvl - 1 == _buyUpgradeFirst.AllPrise.Length)
        {
            _priseFirstUpgrade.text = $"Max";
        }
        if (_countLvl - 1 == _buyUpgradeSecond.AllPrise.Length)
        {
            _priseSecondUpgrade.text = $"Max";
        }
    }
}
