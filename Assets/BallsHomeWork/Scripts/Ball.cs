using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private BallGame game;

    void Start()
    {        
        game = FindObjectOfType<BallGame>();
    }

    void OnMouseDown()
    {        
        game.PopBall(gameObject);
    }
}
