using System;
using TMPro;
using UnityEngine;

public class UpgradeCountBlockUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _priseUpgrade;
    [SerializeField] private TextMeshProUGUI _upgradeText;
    private BuyCountBlock _buyCountBlock;
    private int _countLvl;
    public static Action OnChangeCountBlockUI;
    private void Awake()
    {
        _buyCountBlock = GetComponent<BuyCountBlock>();
    }
    private void Start()
    {
        UpdatePointUI();
    }
    private void OnEnable()
    {
        OnChangeCountBlockUI += UpdatePointUI;
    }
    private void OnDisable()
    {
        OnChangeCountBlockUI -= UpdatePointUI;
    }
    private void UpdatePointUI()
    {
        _countLvl++;
        _priseUpgrade.text = $"${_buyCountBlock.Prise}";
        _upgradeText.text = $"{_countLvl} >> {_countLvl + 1}";
        if(_countLvl - 1 == _buyCountBlock.AllPrise.Length)
        {
            _priseUpgrade.text = $"Max";
            _upgradeText.text = _countLvl.ToString();  
        }
    }
}
