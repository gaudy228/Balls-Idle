using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class RefreshBlocks : MonoBehaviour
{
    private GameObject[] AllBlocks;
    public List<GameObject> CurBlocks;
    public GameObject[] Blocks;
    private int _countBlocks = 1;
    public static Action OnChangeCountBlock;
    public static Action<bool> OnRefresh;
    private int _countRefreshToBoss;
    [SerializeField] private int _maxcountRefreshToBoss;
    private SpawnBoss _spawnBoss;
    [SerializeField] private TextMeshProUGUI _toBossText;
    public bool BossIsActive {  get; private set; }
    [SerializeField] private Tutor _tutor;
    public bool CanRefresh { get; private set; } = true;
    private void Awake()
    {
        _spawnBoss = GetComponent<SpawnBoss>();
    }
    private void Start()
    {
        _countRefreshToBoss = _maxcountRefreshToBoss;
        Refresh(false);
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
        if(CurBlocks.Count == 0 && CanRefresh)
        {
            CanRefresh = false;
            Refresh(true);
        }
    }
    private void ChangeCountBlock()
    {
        _countBlocks++;
    }
    private void Refresh(bool needMinus)
    {
        if (needMinus)
        {
            _countRefreshToBoss--;
        }
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
            CanRefresh = true;
            BossIsActive = false;
        }
        if(_countRefreshToBoss == 0)
        {
            _countRefreshToBoss = _maxcountRefreshToBoss;
            BossIsActive = true;
            _tutor.Skip();
            _spawnBoss.Spawn();
        }
        _toBossText.text = $"Boss: {_countRefreshToBoss}";
    }
}
