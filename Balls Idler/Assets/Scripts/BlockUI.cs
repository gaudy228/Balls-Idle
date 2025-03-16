using System;
using TMPro;
using UnityEngine;
public class BlockUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _hpText;
    public Action<float> OnChangedHp;
    private void OnEnable()
    {
        OnChangedHp += ChangeHp;
    }
    private void OnDisable()
    {
        OnChangedHp -= ChangeHp;
    }
    private void ChangeHp(float hp)
    {
        _hpText.text = hp.ToString();
    }
}
