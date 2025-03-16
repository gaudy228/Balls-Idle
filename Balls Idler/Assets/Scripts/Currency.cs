using System;
using UnityEngine;
public class Currency : MonoBehaviour
{
    private float dollars;
    public static Action<float> OnChangedDollars;
    private void OnEnable()
    {
        OnChangedDollars += ChangeCurrency;
    }
    private void OnDisable()
    {
        OnChangedDollars -= ChangeCurrency;
    }
    public float ReadCurrency()
    {
        return dollars;
    }
    private void ChangeCurrency(float change)
    {
        dollars += change;
        UICurrency.OnChangedUI(dollars);
    }
}
