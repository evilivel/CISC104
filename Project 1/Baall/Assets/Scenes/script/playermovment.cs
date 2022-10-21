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
            gameObject.transform.position += new Vector3(-.01f,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow)&& gameObject.transform.position.x < 2.5)
        {
            gameObject.transform.position += new Vector3(.01f,0,0);
        }

    }
}
