using UnityEngine;
public class BallsMove : MonoBehaviour
{
    public static float Speed;
    public static float Damage;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D _rb;
    private Vector2 _direction;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _direction = new Vector2(Random.Range(-1f, 2f), Random.Range(-1f, 2f));
    }
    void Update()
    {
        _rb.velocity = _direction.normalized * Speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _direction.y = -_direction.y;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            _direction.x = -_direction.x;
        }
        if (collision.gameObject.CompareTag("Block"))
        {
            collision.gameObject.GetComponent<Block>().TakeDamage(Damage);
        }
    }
}
