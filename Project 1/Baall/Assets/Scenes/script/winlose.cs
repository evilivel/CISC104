using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class winlose : MonoBehaviour
{
    public GameObject GreenScoreObject;
    public GameObject YellowScoreObject;
    public GameObject BlueScoreObject;
    public GameObject RedScoreObject;
    public GameObject winLoseObject;

    private TextMeshProUGUI winLoseText { get; set; }
    private TextMeshProUGUI greenScoreText { get; set; }
    private TextMeshProUGUI yellowScoreText { get; set; }
    private TextMeshProUGUI blueScoreText { get; set; }
    private TextMeshProUGUI redScoreText { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        winLoseText = winLoseObject.GetComponent<TextMeshProUGUI>();
        greenScoreText = GreenScoreObject.GetComponent<TextMeshProUGUI>();
        yellowScoreText = YellowScoreObject.GetComponent<TextMeshProUGUI>();
        blueScoreText = BlueScoreObject.GetComponent<TextMeshProUGUI>();
        redScoreText = RedScoreObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");

        if( greenScoreText.text == "out" && yellowScoreText.text == "out" && blueScoreText.text == "out")
        {
            Debug.Log("win");
            foreach(GameObject ball in balls)
            {
                Destroy(ball);
            }
            winLoseText.text = "WIN";

        }
        if(redScoreText.text == "out")
        {
            Debug.Log("lose");
            foreach(GameObject ball in balls)
            {
                Destroy(ball);
            }
            winLoseText.text = "Lose";
        }
        
    }
}
