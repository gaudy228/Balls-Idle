using TMPro;
using UnityEngine;
public class BuyWMoney : Buy
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
        int _multilMoney = PlayerPrefs.GetInt("MultilMoney");
        _multilMoney++;
        _curLvlUpgrade++;
        PlayerPrefs.SetInt("MultilMoney", _multilMoney);
        PlayerPrefs.SetInt("LvlWMoney", _curLvlUpgrade);
        UpdateUI();
    }
    private void UpdateUI()
    {
        _curLvlUpgrade = PlayerPrefs.GetInt("LvlWMoney");
        _priseText.text = $"W{Prise}";
        _lvlText.text = $"{_curLvlUpgrade} >> {_curLvlUpgrade + 1}";
        if (_curLvlUpgrade == AllPrise.Length)
        {
            _priseText.text = $"Max";
            _lvlText.text = $"{_curLvlUpgrade}";
        }
    }
}
