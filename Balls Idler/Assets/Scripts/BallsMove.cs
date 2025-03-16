using UnityEngine;
public class BallsMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D rb;
    private Vector2 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(-1f, 2f), -1);
    }

    void Update()
    {
        rb.velocity = direction.normalized * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            direction.y = -direction.y;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction.x = -direction.x;
        }
        if (collision.gameObject.CompareTag("Block"))
        {
            collision.gameObject.GetComponent<Block>().TakeDamage(1);
        }
    }
}
