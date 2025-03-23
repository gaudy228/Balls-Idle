using System;
using UnityEngine;
public class BallsMove : MonoBehaviour
{
    private int _speed;
    [SerializeField] private BallsFirstUpgrade _ball;
    private Vector2 _direction;
    private Rigidbody2D _rb;
    private BallsDamage _ballDamage;
    public static Action OnChangedStat;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _ballDamage = GetComponent<BallsDamage>();
    }
    void Start()
    {
        _direction = new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;
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
    private void FixedUpdate()
    {
        _rb.velocity = _direction * _speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _direction.y = -_direction.y;
            //_ballDamage.CanDamage = true;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            _direction.x = -_direction.x;
            //_ballDamage.CanDamage = true;
        }
    }
    private void UpdateStat()
    {
        _speed = PlayerPrefs.GetInt(_ball.ToString());
    }
    private enum BallsFirstUpgrade
    {
        RedFirstUpgrade,
        GreenFirstUpgrade,
        BlueFirstUpgrade
    }
}
