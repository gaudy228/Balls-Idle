using System;
using UnityEngine;
public class BallsMove : MonoBehaviour
{
    private int _speed;
    private int _plusSpeed;
    [SerializeField] private BallsFirstUpgrade _ball;
    private Vector2 _direction;
    private Rigidbody2D _rb;
    private BallsDamage _ballDamage;
    public static Action OnChangedStat;
    public static Action OnChangePlusSpeed;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _ballDamage = GetComponent<BallsDamage>();
    }
    void Start()
    {
        UpdatePlusSpeed();
        _direction = new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;
        UpdateStat();
    }
    private void OnEnable()
    {
        UpdatePlusSpeed();
        OnChangedStat += UpdateStat;
        OnChangePlusSpeed += UpdatePlusSpeed;
    }
    private void OnDisable()
    {
        OnChangedStat -= UpdateStat;
        OnChangePlusSpeed -= UpdatePlusSpeed;
    }
    private void FixedUpdate()
    {
        _rb.velocity = _direction * (_speed + _plusSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _direction.y = -_direction.y;
            _ballDamage.CanDamage = true;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            _direction.x = -_direction.x;
            _ballDamage.CanDamage = true;
        }
    }
    private void UpdatePlusSpeed()
    {
        _plusSpeed = PlayerPrefs.GetInt("PlusSpeed");
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
