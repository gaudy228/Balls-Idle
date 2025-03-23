using UnityEngine;
public abstract class Buy : MonoBehaviour
{
    public int Prise { get; private set; }
    public int StartPrise;
    [SerializeField] private int _maxLvl;
    private int _curLvl = 1;
    [SerializeField] private int _multiplPrise;
    private void Awake()
    {
        Prise = StartPrise;
    }
    public void Purchase()
    {
        if(Currency.OnReadDollars() - Prise >= 0 && _curLvl < _maxLvl)
        {
            _curLvl++;
            Currency.OnChangedDollars(-Prise);
            Prise *=  _multiplPrise;
            BuySomething();
        }
    }
    public abstract void BuySomething();
}
