public class BuyClickDamage : Buy
{
    public override void BuySomething()
    {
        Block.OnChangeClickDamage();
        UpgradeClickDamageUI.OnChangeClickDamageUI();
    }
}
