using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEvents : MonoBehaviour
{
    //Ball value
    [SerializeField] private GameObject ball;

    public void SpawnBall() {   
        Instantiate(ball, ball.transform.position, Quaternion.identity);
    }
}
