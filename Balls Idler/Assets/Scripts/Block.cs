using UnityEngine;
using static Unity.Collections.AllocatorManager;
public class Block : MonoBehaviour
{
    [SerializeField] private float _maxHp;
    private float _curHp;
    private BlockUI _blockUI;
    private void Awake()
    {
        _blockUI = GetComponent<BlockUI>(); 
    }
    private void Start()
    {
        _curHp = _maxHp;
        _blockUI.OnChangedHp(_curHp);
    }
    public void TakeDamage(float damage)
    {
        _curHp -= damage;
        Currency.OnChangedDollars(1);
        if (_curHp < 0)
        {
            _curHp = 0;
        }
        _blockUI.OnChangedHp(_curHp);
        if (_curHp == 0)
        {
            Destroy(gameObject);
        }
    }
}
