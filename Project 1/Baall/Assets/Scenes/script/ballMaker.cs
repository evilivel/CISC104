using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMaker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float ballTime = 0;
    private float ballDelay = 10;
    
    void Update()
    {
         //ball spawning
        if (Time.fixedTime == ballTime + ballDelay)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Rigidbody SRB = sphere.AddComponent<Rigidbody>();
            //sphere.GetComponent<Collider>().isTrigger = true;
            SRB.mass = .000001f;
            SRB.drag = .000001f;
            //SRB.angular
            
            sphere.tag = "ball"; 
            
         
            
      

            switch (Mathf.Round(Random.Range(1, 5)))
            {
                case 1:
                    sphere.transform.position = new Vector3(5.62f, 15.27f, 5.9f);
                    break;

                case 2:
                    sphere.transform.position = new Vector3(-5.62f, 15.27f, 5.9f);
                    break;
                case 3:
                    sphere.transform.position = new Vector3(5.62f, 15.27f, -5.9f);
                    break;
                case 4:
                    sphere.transform.position = new Vector3(-5.62f, 15.27f, -5.9f);
                    break;
                default:
                    Debug.Log("baallllsss");
                    break;
            }

            ballTime=Time.fixedTime;

            if (ballDelay > 1)
            {
                ballDelay-=1;
            }
            

        }
    }
}
