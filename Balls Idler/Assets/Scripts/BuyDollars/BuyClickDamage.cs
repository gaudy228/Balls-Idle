using UnityEngine;

public class BuyClickDamage : Buy
{
    public override void BuySomething()
    {
        int _clickDamage = PlayerPrefs.GetInt("ClickDamage");
        _clickDamage++;
        PlayerPrefs.SetInt("ClickDamage", _clickDamage);
        int _maxHp = PlayerPrefs.GetInt("MaxHp");
        _maxHp++;
        PlayerPrefs.SetInt("MaxHp", _maxHp);
        UpgradeClickDamageUI.OnChangeClickDamageUI();
    }
}
