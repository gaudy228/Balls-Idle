using System;
using TMPro;
using UnityEngine;
public class UpgradeClickDamageUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _priseUpgrade;
    [SerializeField] private TextMeshProUGUI _upgradeText;
    private BuyClickDamage _buyClickDamage;
    private int _countLvl;
    public static Action OnChangeClickDamageUI;
    private void Awake()
    {
        _buyClickDamage = GetComponent<BuyClickDamage>();
    }
    private void Start()
    {
        UpdatePointUI();
    }
    private void OnEnable()
    {
        OnChangeClickDamageUI += UpdatePointUI;
    }
    private void OnDisable()
    {
        OnChangeClickDamageUI -= UpdatePointUI;
    }
    private void UpdatePointUI()
    {
        _countLvl++;
        _priseUpgrade.text = $"${_buyClickDamage.Prise}";
        _upgradeText.text = $"{_countLvl} >> {_countLvl + 1}";
        if (_countLvl - 1 == _buyClickDamage.AllPrise.Length)
        {
            _priseUpgrade.text = $"Max";
            _upgradeText.text = _countLvl.ToString();
        }
    }
}
