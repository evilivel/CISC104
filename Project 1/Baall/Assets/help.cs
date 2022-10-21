using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class help : MonoBehaviour
{
    private TextMeshProUGUI yellowScoreText { get; set; }
    // Start is called before the first frame update
    void Start()
    {
       yellowScoreText = gameObject.GetComponent<TextMeshProUGUI>(); 
       yellowScoreText.text = "butt";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
