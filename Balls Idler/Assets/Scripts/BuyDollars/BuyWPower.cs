using TMPro;
using UnityEngine;
public class BuyWPower : Buy
{
    private int _curLvlUpgrade;
    [SerializeField] private TextMeshProUGUI _priseText;
    [SerializeField] private TextMeshProUGUI _lvlText;
    private void Start()
    {
        UpdateUI();
    }
    public override void BuySomething()
    {
        int _multilMoney = PlayerPrefs.GetInt("MultilPower");
        _multilMoney++;
        _curLvlUpgrade++;
        PlayerPrefs.SetInt("MultilPower", _multilMoney);
        PlayerPrefs.SetInt("LvlWPower", _curLvlUpgrade);
        UpdateUI();
    }
    private void UpdateUI()
    {
        _curLvlUpgrade = PlayerPrefs.GetInt("LvlWPower");
        _priseText.text = $"W{Prise}";
        _lvlText.text = $"{_curLvlUpgrade} >> {_curLvlUpgrade + 1}";
        if (_curLvlUpgrade == AllPrise.Length)
        {
            _priseText.text = $"Max";
            _lvlText.text = $"{_curLvlUpgrade}";
        }
    }
}
