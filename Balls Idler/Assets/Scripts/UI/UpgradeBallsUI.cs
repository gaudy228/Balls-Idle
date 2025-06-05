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
    private int _countFirstLvl;
    private int _countSecondLvl;
    public void UpdatePointUI(int countFirstPoint, int countSecondPoint, int whatIsUpgrade)
    {
        if(whatIsUpgrade == 1)
        {
            _countFirstLvl++;
        }
        else if(whatIsUpgrade == 2)
        {
            _countSecondLvl++;
        }
        _priseFirstUpgrade.text = $"${_buyUpgradeFirst.Prise}";
        _priseSecondUpgrade.text = $"${_buyUpgradeSecond.Prise}";
        _firstUpgrade.text = $"{countFirstPoint} >> {countFirstPoint + _upgradeBalls.PlusFirstPoint}";
        _secondUpgrade.text = $"{countSecondPoint} >> {countSecondPoint + _upgradeBalls.PlusSecondPoint}";
        if (_countFirstLvl == _buyUpgradeFirst.AllPrise.Length)
        {
            _priseFirstUpgrade.text = $"Max";
            _firstUpgrade.text = $"{countFirstPoint}";
        }
        if (_countSecondLvl == _buyUpgradeSecond.AllPrise.Length)
        {
            _priseSecondUpgrade.text = $"Max";
            _secondUpgrade.text = $"{countSecondPoint}";
        }
    }
}
