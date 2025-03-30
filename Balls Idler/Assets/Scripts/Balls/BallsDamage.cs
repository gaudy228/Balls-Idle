using System;
using UnityEngine;
public class BallsDamage : MonoBehaviour
{
    protected int _damage;
    protected int _multilMoney;
    [SerializeField] private BallsSecondUpgrade _ball;
    public bool CanDamage { set; private get; } = true;
    public static Action OnChangedStat;
    private void Start()
    {
        UpdateStat();
    }
    private void OnEnable()
    {
        OnChangedStat += UpdateStat;
    }
    private void OnDisable()
    {
        OnChangedStat -= UpdateStat;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block") /*&& CanDamage*/)
        {
            UpdateStat();
            collision.gameObject.GetComponent<Block>().TakeDamage(_damage * _multilMoney);
            AfterDamage();
        }
        if (collision.gameObject.CompareTag("Boss") /*&& CanDamage*/)
        {
            UpdateStat();
            collision.gameObject.GetComponent<Boss>().TakeDamage(_damage * _multilMoney);
            AfterDamage();
        }
    }
    public virtual void AfterDamage()
    {
        CanDamage = false;
    } 
    private void UpdateStat()
    {
        _damage = PlayerPrefs.GetInt(_ball.ToString());
        _multilMoney = PlayerPrefs.GetInt("MultilPower");
    }
    private enum BallsSecondUpgrade
    {
        RedSecondUpgrade,
        GreenSecondUpgrade,
        BlueSecondUpgrade
    }
}
