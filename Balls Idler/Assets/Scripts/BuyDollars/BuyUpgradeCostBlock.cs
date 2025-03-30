using UnityEngine;

public class BuyUpgradeCostBlock : Buy
{
    public override void BuySomething()
    {
        int _cost = PlayerPrefs.GetInt("Cost");
        _cost++;
        PlayerPrefs.SetInt("Cost", _cost);
        int _maxHp = PlayerPrefs.GetInt("MaxHp");
        _maxHp++;
        PlayerPrefs.SetInt("MaxHp", _maxHp);
        UpgradeCostBlockUI.OnChangeCostBlockUI();
    }
}
