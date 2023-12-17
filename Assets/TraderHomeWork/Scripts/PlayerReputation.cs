using UnityEngine;

public enum Reputation
{
    low,
    Medium,
    high
}

public class PlayerReputation : MonoBehaviour
{
    [SerializeField] private Reputation _reputation;

    [SerializeField] private Trader _trader;

    private void Update()
    {

        if (_reputation == Reputation.low)
        {
            _trader.SetTrader(new NoTrade());
        }
        else if (_reputation == Reputation.Medium)
        {
            _trader.SetTrader(new FruitTrade());
        }
        else if (_reputation == Reputation.high)
        {
            _trader.SetTrader(new ArmorTrade());
        }
    }
}
