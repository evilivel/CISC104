using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        gameObject.transform.localScale += new Vector3(0.06f, 0.06f, 0.06f);
    }
}

