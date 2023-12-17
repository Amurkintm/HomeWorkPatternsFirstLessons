using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private BallGame _game;

    void Start()
    {        
        _game = FindObjectOfType<BallGame>();
    }

    void OnMouseDown()
    {        
        _game.PopBall(gameObject);
    }
}
