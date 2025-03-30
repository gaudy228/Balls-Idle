using TMPro;
using UnityEngine;
public class BuyWPower : Buy
{
    private int _curLvl = 1;
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
        _curLvl++;
        PlayerPrefs.SetInt("MultilPower", _multilMoney);
        UpdateUI();
    }
    private void UpdateUI()
    {
        _priseText.text = $"W{Prise}";
        _lvlText.text = $"{_curLvl} >> {_curLvl + 1}";
        if (_curLvl - 1 == AllPrise.Length)
        {
            _priseText.text = $"Max";
        }
    }
}
