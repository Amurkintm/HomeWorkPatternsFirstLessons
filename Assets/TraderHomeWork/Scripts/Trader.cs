using UnityEngine;

public class Trader : MonoBehaviour
{
    private TraderMain _traderMain;
    //private Trader _trader;
    //private void Start()
    //{
    //    _trader = GetComponent<Trader>();
    //}

    public void SetTrader(TraderMain traderMain)
    {
        _traderMain = traderMain;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _traderMain.Trade();
        }
    }
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E)) 
    //    {
    //        trader.SetTrader(new ArmorTrade()); 
    //    }
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        trader.SetTrader(new FruitTrade());
    //    }
    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        trader.SetTrader(new NoTrade());
    //    }
    //}
}
