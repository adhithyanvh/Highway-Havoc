using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public float timeRemain;
    bool timerIsOn = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsOn = true;//sceneload timer
    }

    // Update is called once per frame
    void Update()
    {
        //TIMER FOR SCENELOADING
        if (timerIsOn)
        {
            if(timeRemain > 0)
            {
                timeRemain -= Time.deltaTime;
            }
            else
            {
                timeRemain = 0;
                timerIsOn = false;
                SceneManager.LoadScene(1);

            }
        }
        
        

        
    }
    
}
