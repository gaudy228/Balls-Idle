using TMPro;
using UnityEngine;
public class BuyWSpeed : Buy
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
        int _plusSpeed = PlayerPrefs.GetInt("PlusSpeed");
        _plusSpeed++;
        _curLvlUpgrade++;
        PlayerPrefs.SetInt("PlusSpeed", _plusSpeed);
        PlayerPrefs.SetInt("LvlWSpeed", _curLvlUpgrade);
        UpdateUI();
    }
    private void UpdateUI()
    {
        _curLvlUpgrade = PlayerPrefs.GetInt("LvlWSpeed");
        _priseText.text = $"W{Prise}";
        _lvlText.text = $"{_curLvlUpgrade} >> {_curLvlUpgrade + 1}";
        if (_curLvlUpgrade == AllPrise.Length)
        {
            _priseText.text = $"Max";
            _lvlText.text = $"{_curLvlUpgrade}";
        }
    }
}
