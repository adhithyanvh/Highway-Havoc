using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasThings : MonoBehaviour
{
    //CANVAS

    public TMP_Text scoreText;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score: " + ScoreUpdater.instancee.score.ToString("0");

    }
}
