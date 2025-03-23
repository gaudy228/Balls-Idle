using System;
using TMPro;
using UnityEngine;
public class BlockUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _hpText;
    public void ChangeHp(float hp)
    {
        _hpText.text = hp.ToString();
    }
}
