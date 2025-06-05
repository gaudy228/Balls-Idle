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
        PlayerPrefs.DeleteKey(BallsFirstUpgrade.RedFirstUpgrade.ToString());

        PlayerPrefs.DeleteKey(BallsSecondUpgrade.RedSecondUpgrade.ToString());

        PlayerPrefs.DeleteKey(BallsFirstUpgrade.GreenFirstUpgrade.ToString());

        PlayerPrefs.DeleteKey(BallsSecondUpgrade.GreenSecondUpgrade.ToString());

        PlayerPrefs.DeleteKey(BallsFirstUpgrade.BlueFirstUpgrade.ToString());

        PlayerPrefs.DeleteKey(BallsSecondUpgrade.BlueSecondUpgrade.ToString());

        PlayerPrefs.DeleteKey("MaxHp");

        PlayerPrefs.DeleteKey("ClickDamage");

        PlayerPrefs.DeleteKey("Cost");

        if (PlayerPrefs.HasKey(BallsFirstUpgrade.RedFirstUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsFirstUpgrade.RedFirstUpgrade.ToString(), 1);
        }

        if (PlayerPrefs.HasKey(BallsSecondUpgrade.RedSecondUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsSecondUpgrade.RedSecondUpgrade.ToString(), 1);
        }

        if (PlayerPrefs.HasKey(BallsFirstUpgrade.GreenFirstUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsFirstUpgrade.GreenFirstUpgrade.ToString(), 1);
        }

        if (PlayerPrefs.HasKey(BallsSecondUpgrade.GreenSecondUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsSecondUpgrade.GreenSecondUpgrade.ToString(), 1);
        }

        if (PlayerPrefs.HasKey(BallsFirstUpgrade.BlueFirstUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsFirstUpgrade.BlueFirstUpgrade.ToString(), 1);
        }

        if (PlayerPrefs.HasKey(BallsSecondUpgrade.BlueSecondUpgrade.ToString()) == false)
        {
            PlayerPrefs.SetInt(BallsSecondUpgrade.BlueSecondUpgrade.ToString(), 25);
        }

        if (PlayerPrefs.HasKey("MaxHp") == false)
        {
            PlayerPrefs.SetInt("MaxHp", 9);
        }

        if (PlayerPrefs.HasKey("ClickDamage") == false)
        {
            PlayerPrefs.SetInt("ClickDamage", 1);
        }

        if (PlayerPrefs.HasKey("Cost") == false)
        {
            PlayerPrefs.SetInt("Cost", 1);
        }

        if (PlayerPrefs.HasKey("MultilMoney") == false)
        {
            PlayerPrefs.SetInt("MultilMoney", 1);
        }
        if (PlayerPrefs.HasKey("MultilPower") == false)
        {
            PlayerPrefs.SetInt("MultilPower", 1);
        }
    }
}
