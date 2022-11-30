using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players
{
    private GameObject playerObject;
    private int goalIndex;
    private GameObject[] balls;


    
    public Players()
    {
        playerObject = null;
        goalIndex = 0;
    }
    
    public void PlayerSet (GameObject player, int goal)
    {
        playerObject = player;
        goalIndex = goal;
        
    }

    public GameObject GetGO ()
    {
        return(playerObject);
    }

    public int GetGoal ()
    {
        return(goalIndex);
    }

    //returns closest ball to playerObject moveing in direction of goal given an array of balls 

    public GameObject findBall ()
    {

        GameObject closest = null;
        Vector3 position = playerObject.transform.position;
        GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
        float distance = Mathf.Infinity;

        switch (goalIndex)
        {

            case 1:
                foreach (GameObject ball in balls)
                {
                    float Ballx = ball.GetComponent<Rigidbody>().velocity.x;
                    float Ballz = ball.GetComponent<Rigidbody>().velocity.z;
                    Vector3 diff = ball.transform.position - position;
                    float curDistance = diff.sqrMagnitude;

                    if(Mathf.Abs(Ballx) > Mathf.Abs(Ballz) && Ballx < 0)
                    {
                        if (curDistance < distance)
                        {
                            closest = ball;
                            distance = curDistance;
                        }
                    }

                }
                return(closest);
                

            case 2:
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
                

            case 3:
                foreach (GameObject ball in balls)
                {
                    float Ballx = ball.GetComponent<Rigidbody>().velocity.x;
                    float Ballz = ball.GetComponent<Rigidbody>().velocity.z;
                    Vector3 diff = ball.transform.position - position;
                    float curDistance = diff.sqrMagnitude;

                    if(Mathf.Abs(Ballx) > Mathf.Abs(Ballz) && Ballx > 0)
                    {
                        if (curDistance < distance)
                        {
                            closest = ball;
                            distance = curDistance;
                        }
                    }

                }

                return(closest);
                

            default:
                Debug.Log("no ball");
                return(null);
                
        }
    }

    //intended to be run on game update, moves player to block
   
    public void BlockBall()
    {
        if(playerObject != null)  
        {  
            GameObject closestBall = findBall();
            float Moveto;

            if(closestBall != null)
            {
                switch (goalIndex)
                {
                case 1:
                    Moveto = closestBall.transform.position.z;
                    if(Mathf.Abs(Moveto) < 2.5 && playerObject.transform.position.z < Moveto)
                    {
                        playerObject.transform.position += new Vector3(0f,0f,.015f);
                    }
                    if(Mathf.Abs(Moveto) < 2.5 && playerObject.transform.position.z > Moveto)
                    {
                        playerObject.transform.position += new Vector3(0f,0f,-.015f);
                    }
                break;

                case 2:
                    Moveto = closestBall.transform.position.x;
                    if(Mathf.Abs(Moveto) < 2.5 && playerObject.transform.position.x < Moveto)
                    {
                        playerObject.transform.position += new Vector3(.015f,0f,0);
                    }
                    if(Mathf.Abs(Moveto) < 2.5 && playerObject.transform.position.x > Moveto)
                    {
                        playerObject.transform.position += new Vector3(-.015f,0f,0);
                    }
                break;

                case 3:
                    Moveto = closestBall.transform.position.z;
                    if(Mathf.Abs(Moveto) < 2.5 && playerObject.transform.position.z < Moveto)
                    {
                        playerObject.transform.position += new Vector3(0f,0f,.015f);
                    }   
                    if(Mathf.Abs(Moveto) < 2.5 && playerObject.transform.position.z > Moveto)
                    {
                        playerObject.transform.position += new Vector3(0f,0f,-.015f);
                    }
                break;

                default:
                Debug.Log("no block");
                break;  
                }
            }
        }
        
    }
}
