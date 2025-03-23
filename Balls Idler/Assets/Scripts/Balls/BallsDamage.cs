using System;
using UnityEngine;
public class BallsDamage : MonoBehaviour
{
    private int _damage;
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
            collision.gameObject.GetComponent<Block>().TakeDamage(_damage);
            CanDamage = false;
        }
    }
    private void UpdateStat()
    {
        _damage = PlayerPrefs.GetInt(_ball.ToString());
    }
    private enum BallsSecondUpgrade
    {
        RedSecondUpgrade,
        GreenSecondUpgrade,
        BlueSecondUpgrade
    }
}
