using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playermovment : MonoBehaviour
{
    public GameObject YellowObject;
    public GameObject BlueObject;
    public GameObject GreenObject;

    public Players yellowPlayer = new Players();
    public Players bluePlayer = new Players();
    public Players greenPlayer = new Players();


    void Start()
    {
        yellowPlayer.PlayerSet(YellowObject,1);
        Debug.Log("yellow player go");
        bluePlayer.PlayerSet(BlueObject,2);
        Debug.Log("blue player go");
        greenPlayer.PlayerSet(GreenObject,3);
        Debug.Log("green player go");

    }

    void OnCollisionEnter(Collision collision)
    {

    }




    //public int ballNumber = 0;
    
    

    void Update()
    {

        yellowPlayer.BlockBall();
        bluePlayer.BlockBall();
        greenPlayer.BlockBall();



        
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > -2.5 )
        {
            gameObject.transform.position += new Vector3(-.015f,0,0);
            

        }
        else if (Input.GetKey(KeyCode.RightArrow)&& gameObject.transform.position.x < 2.5)
        {
            gameObject.transform.position += new Vector3(.015f,0,0);
            
        }
        else
        {
            
        }

    }
}
