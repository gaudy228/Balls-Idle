using UnityEngine;
public abstract class Buy : MonoBehaviour
{
    public int Prise { get; private set; }
    public int[] AllPrise;
    public int CurLvl { get; private set; }
    private void Awake()
    {
        Prise = AllPrise[CurLvl];
    }
    public void Purchase()
    {
        if(Currency.OnReadDollars() - Prise >= 0 && CurLvl < AllPrise.Length - 1)
        {
            CurLvl++;
            Currency.OnChangedDollars(-Prise);
            Prise = AllPrise[CurLvl];
            BuySomething();
        }
    }
    public abstract void BuySomething();
}
