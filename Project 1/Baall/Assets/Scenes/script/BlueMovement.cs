using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMovement : MonoBehaviour
{
    public GameObject findBall (GameObject[] balls)
    {

        GameObject closest = null;
        Vector3 position = transform.position;
        float distance = Mathf.Infinity;


            foreach (GameObject ball in balls)
            {
                float Ballx = ball.GetComponent<Rigidbody>().velocity.x;
                float Ballz = ball.GetComponent<Rigidbody>().velocity.z;
                Vector3 diff = ball.transform.position - position;
                float curDistance = diff.sqrMagnitude;

                if(Mathf.Abs(Ballx) < Mathf.Abs(Ballz) && Ballz > 0)
                {
                    if (curDistance < distance)
                    {
                        closest = ball;
                        distance = curDistance;
                    }
                }

            }

        return(closest);
    }
    
    void Start()
    {
        
    }

    private GameObject[] balls;
    void Update()
    {
        balls = GameObject.FindGameObjectsWithTag("ball");
        GameObject closestBall = findBall(balls);
        
        if(closestBall != null)
        {
            float Moveto = closestBall.transform.position.x;
            if(Mathf.Abs(Moveto) < 2.5 && gameObject.transform.position.x < Moveto)
            {
                gameObject.transform.position += new Vector3(.01f,0f,0);
            }
            if(Mathf.Abs(Moveto) < 2.5 && gameObject.transform.position.x > Moveto)
            {
                gameObject.transform.position += new Vector3(-.01f,0f,0);
            }
        }
        
    }
}
