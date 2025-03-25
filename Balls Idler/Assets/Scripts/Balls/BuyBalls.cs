using UnityEngine;
public class BuyBalls : Buy
{
    [SerializeField] private GameObject _ballsPrefab;
    public bool CanUpgradeBall { get; private set; } = false;
    public override void BuySomething()
    {
        Instantiate(_ballsPrefab, new Vector3(0,0,0), Quaternion.identity);
        CanUpgradeBall = true;
    }
}
