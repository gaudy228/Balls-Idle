using UnityEngine;
public class GreenBallsDamage : BallsDamage
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _block;
    public override void AfterDamage()
    {
        base.AfterDamage();
        Damage();
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, _radius);
    }
    private void Damage()
    {
        Collider2D[] block = Physics2D.OverlapCircleAll(transform.position, _radius, _block);
        for (int i = 0; i < block.Length; i++)
        {
            if (block[i].GetComponent<Boss>())
            {
                return;
            }
            block[i].GetComponent<Block>().TakeDamage(_damage * _multilMoney);
        }
    }
}
