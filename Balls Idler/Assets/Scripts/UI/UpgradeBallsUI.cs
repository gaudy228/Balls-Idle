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
    private int _countLvl;
    public void UpdatePointUI(int countFirstPoint, int countSecondPoint)
    {
        _countLvl++;
        _priseFirstUpgrade.text = $"${_buyUpgradeFirst.Prise}";
        _priseSecondUpgrade.text = $"${_buyUpgradeSecond.Prise}";
        _firstUpgrade.text = $"{countFirstPoint} >> {countFirstPoint + 1}";
        _secondUpgrade.text = $"{countSecondPoint} >> {countSecondPoint + 1}";
        if (_countLvl == _buyUpgradeFirst.AllPrise.Length)
        {
            _priseFirstUpgrade.text = $"Max";
        }
        if (_countLvl == _buyUpgradeSecond.AllPrise.Length)
        {
            _priseSecondUpgrade.text = $"Max";
        }
    }
}
