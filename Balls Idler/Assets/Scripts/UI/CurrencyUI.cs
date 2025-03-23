using System;
using TMPro;
using UnityEngine;
public class CurrencyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countDollars;
    public static Action<float> OnChangedUI;
    private void OnEnable()
    {
        OnChangedUI += ChangeUIDollars;
    }
    private void OnDisable()
    {
        OnChangedUI -= ChangeUIDollars;
    }
    private void ChangeUIDollars(float dollars)
    {
        _countDollars.text = dollars.ToString();
    }
}
