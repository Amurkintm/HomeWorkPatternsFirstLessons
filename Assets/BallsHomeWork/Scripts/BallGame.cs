using System.Collections.Generic;
using UnityEngine;
public enum VictorySet
{
    ���,
    �����������
}
public class BallGame : MonoBehaviour
{
    public VictorySet VictorySet;
    public List<GameObject> RedBalls;
    public List<GameObject> WhiteBalls;
    public List<GameObject> GreenBalls;

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
