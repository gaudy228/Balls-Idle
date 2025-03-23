using UnityEngine;
public class DefaultStat : MonoBehaviour
{
    private enum BallsFirstUpgrade
    {
        RedFirstUpgrade,
        GreenFirstUpgrade,
        BlueFirstUpgrade
    }
    private enum BallsSecondUpgrade
    {
        RedSecondUpgrade,
        GreenSecondUpgrade,
        BlueSecondUpgrade
    }
    private void Awake()
    {
        if (PlayerPrefs.HasKey(BallsFirstUpgrade.RedFirstUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsFirstUpgrade.RedFirstUpgrade.ToString(), 1);
        }
        if (PlayerPrefs.HasKey(BallsSecondUpgrade.RedSecondUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsSecondUpgrade.RedSecondUpgrade.ToString(), 1);
        }
        if (PlayerPrefs.HasKey("MaxHp") == false)
        {
            PlayerPrefs.SetInt("MaxHp", 10);
        }
    }
}
