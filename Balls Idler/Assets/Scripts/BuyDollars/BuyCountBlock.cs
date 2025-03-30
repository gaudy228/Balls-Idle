using UnityEngine;
public class BuyCountBlock : Buy
{
    [SerializeField] private int _plusHp;
    [SerializeField] private RefreshBlocks _refreshBlocks;
    public override void BuySomething()
    {
        RefreshBlocks.OnChangeCountBlock();
        UpgradeCountBlockUI.OnChangeCountBlockUI();
        int _maxHp = PlayerPrefs.GetInt("MaxHp");
        _maxHp += _plusHp;
        PlayerPrefs.SetInt("MaxHp", _maxHp);
        if (_refreshBlocks.CanRefresh)
        {
            RefreshBlocks.OnRefresh(false);
        }
    }
}
