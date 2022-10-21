using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class redGoal : MonoBehaviour
{
    public GameObject RedScoreObject;
    public GameObject Redplayer;
    private TextMeshProUGUI redScoreText { get; set; }
    
    public int redScore = 10;

    void Start()
    {
       redScoreText = RedScoreObject.GetComponent<TextMeshProUGUI>(); 
      
    }


    private void OnCollisionEnter(Collision collision)
    {
         

        if ( collision.gameObject.tag == "ball" && redScore > 1 )
        {
           Destroy(collision.gameObject);
           redScore -= 1;
           
           Debug.Log(redScore);
           redScoreText.text = redScore.ToString();
        }
        else
        {
            redScoreText.text = "out";
            Destroy(Redplayer);
        }
 }  



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
 
    }
}
