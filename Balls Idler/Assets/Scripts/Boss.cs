using UnityEngine;
public class Boss : MonoBehaviour
{
    [SerializeField] private int _maxHp = 500;
    [SerializeField] private int _multiplHp;
    private int _curHp;
    private int _clickDamage = 1;
    private int _costW = 1;
    private BlockUI _blockUI;
    private void Awake()
    {
        _blockUI = GetComponent<BlockUI>();
    }
    private void Start()
    {
        _clickDamage = PlayerPrefs.GetInt("ClickDamage");
        _curHp = _maxHp;
        _blockUI.ChangeHp(_curHp);
    }
    private void OnEnable()
    {
        _clickDamage = PlayerPrefs.GetInt("ClickDamage");
        _curHp = _maxHp;
        _blockUI.ChangeHp(_curHp);
    }
    public void ClickDamage()
    {
        _clickDamage = PlayerPrefs.GetInt("ClickDamage");
        TakeDamage(_clickDamage);
    }
    public void TakeDamage(int damage)
    {
        _curHp -= damage;
        if (_curHp < 0)
        {
            _curHp = 0;
        }
        _blockUI.ChangeHp(_curHp);
        if(_curHp == 0)
        {
            _maxHp *= _multiplHp;
            RefreshBlocks.OnRefresh(false);
            Currency.OnChangedRebornPoint(_costW);
            gameObject.SetActive(false);
            
        }
    }
}
