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
    private void Start()
    {
        Refresh();
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
        AllBlocks = new GameObject[_countBlocks];
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
}
