using TMPro;
using UnityEngine;
public class BuyBallsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _priseText;
    [SerializeField] private GameObject _upgradePanel;
    private BuyBalls _buyBalls;
    private void Awake()
    {
        _buyBalls = GetComponent<BuyBalls>();
    }
    private void Start()
    {
        UpdatePriseUI();
    }
    public void UpdatePriseUI()
    {
        _priseText.text = $"${_buyBalls.Prise}";
        _upgradePanel.SetActive(_buyBalls.CanUpgradeBall);
    }
}
