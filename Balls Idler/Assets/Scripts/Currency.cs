using System;
using UnityEngine;
public class Currency : MonoBehaviour
{
    [SerializeField] private int _dollars;
    private int _wDollars;
    private int _rebornPoint;
    private int _multilMoney;
    public static Action<int> OnChangedDollars;
    public static Func<int> OnReadDollars;
    public static Action<int> OnChangedRebornPoint;
    public static Func<int> OnReadW;
    public static Action OnRebornWDollars;
    public static Action<int> OnChangeWDollars;
    private void Start()
    {
        _multilMoney = PlayerPrefs.GetInt("MultilMoney");
        _wDollars = PlayerPrefs.GetInt("WDollars");
        CurrencyUI.OnChangedWDollarsUI(_wDollars);
    }
    private void OnEnable()
    {
        OnChangedDollars += ChangeDefaultDollars;
        OnReadDollars += ReadDefaultDollars;
        OnChangedRebornPoint += ChangeRebornPoint;
        OnReadW += ReadWDollars;
        OnRebornWDollars += RebornWDollars;
        OnChangeWDollars += ChangeWDollars;
    }
    private void OnDisable()
    {
        OnChangedDollars -= ChangeDefaultDollars;
        OnReadDollars -= ReadDefaultDollars;
        OnChangedRebornPoint -= ChangeRebornPoint;
        OnReadW -= ReadWDollars;
        OnRebornWDollars -= RebornWDollars;
        OnChangeWDollars -= ChangeWDollars;
    }
    private int ReadDefaultDollars()
    {
        return _dollars;
    }
    private int ReadWDollars()
    {
        return _wDollars;
    }
    private void ChangeDefaultDollars(int change)
    {
        if(change < 0)
        {
            _dollars += change;
        }
        else
        {
            _multilMoney = PlayerPrefs.GetInt("MultilMoney");
            _dollars += change * _multilMoney;
        }
        CurrencyUI.OnChangedDefaultDollarsUI(_dollars);
    }
    private void ChangeRebornPoint(int change)
    {
        _rebornPoint += change;
        CurrencyUI.OnChangedRebornPointUI(_rebornPoint);
    }
    private void RebornWDollars()
    {
        ChangeWDollars(_rebornPoint);
    }
    private void ChangeWDollars(int change)
    {
        _wDollars += change;
        PlayerPrefs.SetInt("WDollars", _wDollars);
        CurrencyUI.OnChangedWDollarsUI(_wDollars);
    }
}
