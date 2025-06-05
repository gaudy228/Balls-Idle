using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    [SerializeField] private GameObject _boss;

    public void Spawn()
    {
        _boss.SetActive(true);
    }
}
