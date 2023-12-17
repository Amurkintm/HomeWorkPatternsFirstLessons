using System.Collections.Generic;
using UnityEngine;
public enum VictorySet
{
    ���,
    �����������
}
public class BallGame : MonoBehaviour
{
    [SerializeField] private List<GameObject> RedBalls;
    [SerializeField] private List<GameObject> WhiteBalls;
    [SerializeField] private List<GameObject> GreenBalls;
    
    [SerializeField] private VictorySet VictorySet;
    
    private IVictorySet victorySet;

    void Start()
    {
        if (VictorySet == VictorySet.���)
        {
            victorySet = new AllBallsVictory();
        }
        if (VictorySet == VictorySet.�����������)
        {
            victorySet = new SingleColorVictory();
        }
    }

    void Update()
    {
        if (victorySet.CheckVictory(RedBalls, WhiteBalls, GreenBalls))
        {
            Debug.Log("�� ��������!");
        }
    }

    public void PopBall(GameObject ball)
    {
        if (RedBalls.Contains(ball))
        {
            RedBalls.Remove(ball);
        }
        else if (WhiteBalls.Contains(ball))
        {
            WhiteBalls.Remove(ball);
        }
        else if (GreenBalls.Contains(ball))
        {
            GreenBalls.Remove(ball);
        }
        Destroy(ball);
    }
}
