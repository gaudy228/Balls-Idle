using UnityEngine;
public abstract class Buy : MonoBehaviour
{
    public int Prise { get; private set; }
    public int[] AllPrise;
    public int CurCost { get; private set; }
    [SerializeField] private bool _isWDollars;
    [SerializeField] private WhatWUpgrade _wUpgrade;
    private void Awake()
    {
        if(_isWDollars)
        {
            CurCost = PlayerPrefs.GetInt(_wUpgrade.ToString());
        }
        Prise = AllPrise[CurCost];
    }
    public void Purchase()
    {
        if(Currency.OnReadDollars() - Prise >= 0 && CurCost != AllPrise.Length)
        {
            CurCost++;
            Currency.OnChangedDollars(-Prise);
            if (CurCost != AllPrise.Length)
            {
                Prise = AllPrise[CurCost];
            }
            BuySomething();
        }
    }
    public void PurchaseW()
    {
        if (Currency.OnReadW() - Prise >= 0 && CurCost != AllPrise.Length)
        {
            CurCost++;
            Currency.OnChangeWDollars(-Prise);
            if(CurCost != AllPrise.Length)
            {
                Prise = AllPrise[CurCost];
                PlayerPrefs.SetInt(_wUpgrade.ToString(), CurCost);
            }
            BuySomething();
        }
    }
    public abstract void BuySomething();

    private enum WhatWUpgrade
    {
        None,
        Money,
        Speed,
        Power
    }
}
