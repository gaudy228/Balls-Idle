using UnityEngine;
public class BuyCountBlock : Buy
{
    [SerializeField] private int _plusHp;
    public override void BuySomething()
    {
        RefreshBlocks.OnChangeCountBlock();
        UpgradeCountBlockUI.OnChangeCountBlockUI();
        int _maxHp = PlayerPrefs.GetInt("MaxHp");
        _maxHp += _plusHp;
        PlayerPrefs.SetInt("MaxHp", _maxHp);
        RefreshBlocks.OnRefresh();
    }
}
