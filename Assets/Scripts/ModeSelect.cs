using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelect : MonoBehaviour
{
    public static ModeSelect instanceeee;
    public int mode;
    // Start is called before the first frame update
    void Start()
    {
        instanceeee = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModeOne()
    {
        SceneManager.LoadScene(4);
        mode = 1;

    }
    public void ModeTwo()
    {
        SceneManager.LoadScene(5);
        mode = 2;
    }
}
