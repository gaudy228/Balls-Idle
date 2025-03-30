using System;
using TMPro;
using UnityEngine;
public class CurrencyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countDollars;
    public static Action<int> OnChangedDefaultDollarsUI;
    [SerializeField] private TextMeshProUGUI _countWDollars;
    public static Action<int> OnChangedWDollarsUI;
    [SerializeField] private TextMeshProUGUI _countRebornPoint;
    public static Action<int> OnChangedRebornPointUI;
    private void OnEnable()
    {
        OnChangedDefaultDollarsUI += ChangeUIDollars;
        OnChangedWDollarsUI += ChangeWUIDollars;
        OnChangedRebornPointUI += ChangeRebornPointUI;
    }
    private void OnDisable()
    {
        OnChangedDefaultDollarsUI -= ChangeUIDollars;
        OnChangedWDollarsUI -= ChangeWUIDollars;
        OnChangedRebornPointUI -= ChangeRebornPointUI;
    }
    private void ChangeUIDollars(int dollars)
    {
        _countDollars.text = dollars.ToString();
    }
    private void ChangeWUIDollars(int wDollars)
    {
        _countWDollars.text = wDollars.ToString();
    }
    private void ChangeRebornPointUI(int rebornPoint)
    {
        _countRebornPoint.text = $"Reborn point: {rebornPoint}";
    }
}
