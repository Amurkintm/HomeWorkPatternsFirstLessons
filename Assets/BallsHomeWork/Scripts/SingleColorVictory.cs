using System.Collections.Generic;
using UnityEngine;

public class SingleColorVictory : IVictorySet
{
    public bool CheckVictory(List<GameObject> redBalls, List<GameObject> whiteBalls, List<GameObject> greenBalls)
    {
        return redBalls.Count == 0 || whiteBalls.Count == 0 || greenBalls.Count == 0;
    }
}
