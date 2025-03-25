using System;
using UnityEngine;
public class Block : MonoBehaviour
{
    private int _maxHp = 10;
    public int CurHp { get; private set; }
    private int _clickDamage = 1;
    private BlockUI _blockUI;
    private BlockCost _blockCost;
    public static Action OnChangeClickDamage;
    private void Awake()
    {
        _blockUI = GetComponent<BlockUI>();
        _blockCost = GetComponent<BlockCost>();
    }
    private void Start()
    {
        _maxHp = PlayerPrefs.GetInt("MaxHp");
        _clickDamage = PlayerPrefs.GetInt("ClickDamage");
        CurHp = _maxHp;
        _blockUI.ChangeHp(CurHp);
    }
    private void OnEnable()
    {
        _maxHp = PlayerPrefs.GetInt("MaxHp");
        CurHp = _maxHp;
        _blockUI.ChangeHp(CurHp);
        OnChangeClickDamage += ChangeClickDamage;
    }
    private void OnDisable()
    {
        OnChangeClickDamage -= ChangeClickDamage;
    }
    private void ChangeClickDamage()
    {
        _clickDamage++;
        PlayerPrefs.SetInt("ClickDamage", _clickDamage);
        PlusHp();
    }
    public void PlusHp()
    {
        _maxHp++;
        PlayerPrefs.SetInt("MaxHp", _maxHp);
        if (CurHp < _maxHp)
        {
            CurHp++;
        }
        _blockUI.ChangeHp(CurHp);
    }
    public void ClickDamage()
    {
        TakeDamage(_clickDamage);
    }
    public void TakeDamage(int damage)
    {
        CurHp -= damage;
        if (CurHp < 0)
        {
            CurHp = 0;
        }
        _blockUI.ChangeHp(CurHp);
        _blockCost.DeadBlock();
    }

}
