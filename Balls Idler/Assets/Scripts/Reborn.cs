using UnityEngine;
using UnityEngine.SceneManagement;

public class Reborn : MonoBehaviour
{
    public void Reborning()
    {
        Currency.OnRebornWDollars();
        SceneManager.LoadScene(0);
    }
}
