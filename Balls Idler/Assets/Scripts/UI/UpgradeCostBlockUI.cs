using System;
using TMPro;
using UnityEngine;
public class UpgradeCostBlockUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _priseUpgrade;
    [SerializeField] private TextMeshProUGUI _upgradeText;
    private BuyUpgradeCostBlock _buyUpgradeCostBlock;
    private int _countLvl;
    public static Action OnChangeCostBlockUI;
    private void Awake()
    {
        _buyUpgradeCostBlock = GetComponent<BuyUpgradeCostBlock>();
    }
    private void Start()
    {
        UpdatePointUI();
    }
    private void OnEnable()
    {
        OnChangeCostBlockUI += UpdatePointUI;
    }
    private void OnDisable()
    {
        OnChangeCostBlockUI -= UpdatePointUI;
    }
    private void UpdatePointUI()
    {
        _countLvl++;
        _priseUpgrade.text = $"${_buyUpgradeCostBlock.Prise}";
        _upgradeText.text = $"{_countLvl} >> {_countLvl + 1}";
        if (_countLvl == _buyUpgradeCostBlock.AllPrise.Length)
        {
            _priseUpgrade.text = $"Max";
        }
    }
}
