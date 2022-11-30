using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGoundPhys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        PhysicMaterial bounce = new PhysicMaterial();
        bounce.bounciness = 1;
        bounce.bounceCombine = PhysicMaterialCombine.Maximum;
        
        
        if ( collision.gameObject.tag == "ball")
        {
            //collision.gameObject.GetComponent<Collider>().material = bounce;
            collision.gameObject.GetComponent<Rigidbody>().velocity = 10 * (collision.gameObject.GetComponent<Rigidbody>().velocity.normalized);
            //collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            
          
        }
        else
        {

        }
 }  
}
