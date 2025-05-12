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
        SceneManager.LoadScene(2);
        mode = 1;

    }
    public void ModeTwo()
    {
        SceneManager.LoadScene(7);
        mode = 2;
    }
}
