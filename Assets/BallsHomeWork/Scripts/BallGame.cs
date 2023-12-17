using System.Collections.Generic;
using UnityEngine;
public enum VictorySet
{
    ���,
    �����������
}
public class BallGame : MonoBehaviour
{
    [SerializeField] private List<GameObject> _redBalls;
    [SerializeField] private List<GameObject> _whiteBalls;
    [SerializeField] private List<GameObject> _greenBalls;
    
    [SerializeField] private VictorySet _victorySetEnum;
    
    private IVictorySet _victorySet;

    void Start()
    {
        if (_victorySetEnum == VictorySet.���)
        {
            _victorySet = new AllBallsVictory();
        }
        if (_victorySetEnum == VictorySet.�����������)
        {
            _victorySet = new SingleColorVictory();
        }
    }

    void Update()
    {
        if (_victorySet.CheckVictory(_redBalls, _whiteBalls, _greenBalls))
        {
            Debug.Log("�� ��������!");
        }
    }

    public void PopBall(GameObject ball)
    {
        if (_redBalls.Contains(ball))
        {
            _redBalls.Remove(ball);
        }
        else if (_whiteBalls.Contains(ball))
        {
            _whiteBalls.Remove(ball);
        }
        else if (_greenBalls.Contains(ball))
        {
            _greenBalls.Remove(ball);
        }
        Destroy(ball);
    }
}
