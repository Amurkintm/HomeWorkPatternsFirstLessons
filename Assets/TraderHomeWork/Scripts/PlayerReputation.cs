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

    [SerializeField] private Trader Trader;

    private void Update()
    {

        if (_reputation == Reputation.low)
        {
            Trader.SetTrader(new NoTrade());
        }
        else if (_reputation == Reputation.Medium)
        {
            Trader.SetTrader(new FruitTrade());
        }
        else if (_reputation == Reputation.high)
        {
            Trader.SetTrader(new ArmorTrade());
        }
    }
}
