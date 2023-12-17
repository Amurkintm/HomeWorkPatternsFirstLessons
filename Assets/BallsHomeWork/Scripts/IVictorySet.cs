using System.Collections.Generic;
using UnityEngine;

public interface IVictorySet
{
    bool CheckVictory(List<GameObject> redBalls, List<GameObject> whiteBalls, List<GameObject> greenBalls);
}
