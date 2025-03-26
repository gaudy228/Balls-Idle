using System;
using System.Collections.Generic;
using UnityEngine;
public class RefreshBlocks : MonoBehaviour
{
    private GameObject[] AllBlocks;
    public List<GameObject> CurBlocks;
    public GameObject[] Blocks;
    private int _countBlocks = 1;
    public static Action OnChangeCountBlock;
    public static Action OnRefresh;
    private int _countRefreshToBoss;
    [SerializeField] private int _maxcountRefreshToBoss = 3;
    private SpawnBoss _spawnBoss;
    private void Awake()
    {
        _spawnBoss = GetComponent<SpawnBoss>();
    }
    private void Start()
    {
        Refresh();
        _countRefreshToBoss = _maxcountRefreshToBoss;
    }
    private void OnEnable()
    {
        OnChangeCountBlock += ChangeCountBlock;
        OnRefresh += Refresh;
    }
    private void OnDisable()
    {
        OnChangeCountBlock -= ChangeCountBlock;
        OnRefresh -= Refresh;
    }
    private void Update()
    {
        if(CurBlocks.Count == 0)
        {
            Refresh();
        }
    }
    private void ChangeCountBlock()
    {
        _countBlocks++;
    }
    private void Refresh()
    {
        _countRefreshToBoss--;
        int _maxHp = PlayerPrefs.GetInt("MaxHp");
        _maxHp++;
        PlayerPrefs.SetInt("MaxHp", _maxHp);
        AllBlocks = new GameObject[_countBlocks];
        if(_countRefreshToBoss > 0)
        {
            for (int i = 0; i < _countBlocks; i++)
            {
                AllBlocks[i] = Blocks[i];
            }
            CurBlocks = new List<GameObject>(AllBlocks);
            for (int i = 0; i < AllBlocks.Length; i++)
            {
                AllBlocks[i].SetActive(true);
            }
        }
        if(_countRefreshToBoss == 0)
        {
            _spawnBoss.Spawn();
            _countRefreshToBoss = _maxcountRefreshToBoss;
        }
    }
}
