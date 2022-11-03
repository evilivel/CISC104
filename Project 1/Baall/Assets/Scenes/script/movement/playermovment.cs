using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    void OnCollisionEnter(Collision collision)
    {

    }




    //public int ballNumber = 0;
    
    

    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > -2.5 )
        {
            gameObject.transform.position += new Vector3(-.015f,0,0);
            //gameObject.GetComponent<Rigidbody>().AddForce(-10,0,0,ForceMode.VelocityChange);

        }
        else if (Input.GetKey(KeyCode.RightArrow)&& gameObject.transform.position.x < 2.5)
        {
            gameObject.transform.position += new Vector3(.015f,0,0);
            //gameObject.GetComponent<Rigidbody>().AddForce(10,0,0,ForceMode.VelocityChange);
        }
        else
        {
            //gameObject.GetComponent<Rigidbody>().AddForce(0,0,0,ForceMode.VelocityChange);
        }

    }
}
