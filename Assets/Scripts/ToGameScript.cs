using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayScene()
    {
        SceneManager.LoadScene(2);
    }
    public void CarSelectScene()
    {
        SceneManager.LoadScene(2);

    }

    public void TwoLaneScene()
    {
        SceneManager.LoadScene(2);
    }
}
