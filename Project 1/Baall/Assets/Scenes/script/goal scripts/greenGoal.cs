using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class greenGoal : MonoBehaviour
{
    public GameObject GreenScoreObject;
    public GameObject Greenplayer;
    private TextMeshProUGUI greenScoreText { get; set; }
    
    public int greenScore = 10;

    void Start()
    {
       greenScoreText = GreenScoreObject.GetComponent<TextMeshProUGUI>(); 
      
    }


    private void OnCollisionEnter(Collision collision)
    {
         

        if ( collision.gameObject.tag == "ball" && greenScore > 1)
        {
           Destroy(collision.gameObject);
           greenScore -= 1;
           
           Debug.Log(greenScore);
           greenScoreText.text = greenScore.ToString();
        }
                else
        {
            greenScoreText.text = "out";
            Destroy(Greenplayer);
        }
 }  



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
 
    }
}
