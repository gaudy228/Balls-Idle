using System;
using UnityEngine;
public class BlockCost : MonoBehaviour
{
    private int _cost = 1;
    private Block _block;
    public static Action OnChangeCost;
    private RefreshBlocks _refreshBlocks;
    private void Awake()
    {
        _refreshBlocks = GameObject.FindWithTag("BlockManager").GetComponent<RefreshBlocks>();
        _block = GetComponent<Block>();
    }
    private void OnEnable()
    {
        OnChangeCost += CostIncrease;
    }
    private void OnDisable()
    {
        OnChangeCost -= CostIncrease;
    }
    private void CostIncrease()
    {
        _cost++;
        _block.PlusHp();
    }
    public void DeadBlock()
    {
        if(_block.CurHp == 0)
        {
            Currency.OnChangedDollars(_cost);
            _refreshBlocks.CurBlocks.Remove(gameObject);
            gameObject.SetActive(false);
        }
    }
}
