using System;
using UnityEngine;
public class BlockCost : MonoBehaviour
{
    private int _cost = 1;
    private Block _block;
    private RefreshBlocks _refreshBlocks;
    private void Awake()
    {
        _refreshBlocks = GameObject.FindWithTag("BlockManager").GetComponent<RefreshBlocks>();
        _block = GetComponent<Block>();
        _cost = PlayerPrefs.GetInt("Cost");
    }
    private void OnEnable()
    {
        _cost = PlayerPrefs.GetInt("Cost");
    }
    public void DeadBlock()
    {
        if(_block.CurHp == 0)
        {
            _cost = PlayerPrefs.GetInt("Cost");
            Currency.OnChangedDollars(_cost);
            _refreshBlocks.CurBlocks.Remove(gameObject);
            gameObject.SetActive(false);
        }
    }
}
