using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class blueGoal : MonoBehaviour
{
    public GameObject BlueScoreObject;
    public GameObject Blueplayer;
    private TextMeshProUGUI blueScoreText { get; set; }
    
    public int blueScore = 10;

    void Start()
    {
       blueScoreText = BlueScoreObject.GetComponent<TextMeshProUGUI>(); 
      
    }


    private void OnCollisionEnter(Collision collision)
    {
         

        if ( collision.gameObject.tag == "ball" && blueScore > 1)
        {
           Destroy(collision.gameObject);
           blueScore -= 1;
           
           Debug.Log(blueScore);
           blueScoreText.text = blueScore.ToString();
        }
        else
        {
            blueScoreText.text = "out";
            Destroy(Blueplayer);
        }
 }  



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
 
    }
}
