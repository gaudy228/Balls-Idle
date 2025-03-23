using System;
using UnityEngine;
public class Currency : MonoBehaviour
{
    private float dollars;
    public static Action<float> OnChangedDollars;
    public static Func<float> OnReadDollars;
    private void OnEnable()
    {
        OnChangedDollars += ChangeCurrency;
        OnReadDollars += ReadCurrency;
    }
    private void OnDisable()
    {
        OnChangedDollars -= ChangeCurrency;
        OnReadDollars -= ReadCurrency;
    }
    public float ReadCurrency()
    {
        return dollars;
    }
    private void ChangeCurrency(float change)
    {
        dollars += change;
        CurrencyUI.OnChangedUI(dollars);
    }
}
