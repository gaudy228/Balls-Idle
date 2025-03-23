using UnityEngine;
public class BuyUpgrade : Buy
{
    [SerializeField] private bool _firstUpgrage;
    private UpgradeBalls _upgradeBalls;
    private void Start()
    {
        _upgradeBalls = GetComponent<UpgradeBalls>();
    }
    public override void BuySomething()
    {
        if (_firstUpgrage)
        {
            _upgradeBalls.FirstUpgrade();
        }
        else if(!_firstUpgrage)
        {
            _upgradeBalls.SecondUpgrade();
        }
    }
}
