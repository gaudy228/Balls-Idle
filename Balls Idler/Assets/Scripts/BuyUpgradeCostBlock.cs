public class BuyUpgradeCostBlock : Buy
{
    public override void BuySomething()
    {
        BlockCost.OnChangeCost();
        UpgradeCostBlockUI.OnChangeCostBlockUI();
    }
}
