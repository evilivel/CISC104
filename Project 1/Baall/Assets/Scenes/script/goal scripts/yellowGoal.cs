using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class yellowGoal : MonoBehaviour
{
    public GameObject YellowScoreObject;
    public GameObject Yellowplayer;
    private TextMeshProUGUI yellowScoreText { get; set; }
    
    public int yellowScore = 10;

    void Start()
    {
       yellowScoreText = YellowScoreObject.GetComponent<TextMeshProUGUI>(); 
       //yellowScoreText.text = "butt";
    }


    private void OnCollisionEnter(Collision collision)
    {
         

        if ( collision.gameObject.tag == "ball" && yellowScore > 1 )
        {
           Destroy(collision.gameObject);
           yellowScore -= 1;
           
           Debug.Log(yellowScore);
           yellowScoreText.text = yellowScore.ToString();
        }
        else
        {
            yellowScoreText.text = "out";
            Destroy(Yellowplayer);
        }
 }  



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //yScoreText.text = yellowScore.ToString();
    }
}
