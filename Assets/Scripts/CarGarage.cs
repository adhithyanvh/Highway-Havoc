using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CarGarage : MonoBehaviour
{
    public GameObject CameraPos1,CameraPos2,CameraPos3;
    public Camera myCamera;
    public Button FirstNextButton,SecondNextButton,ThirdNextButton;
    public Button Select1, Select2, Select3;
    public int carNumber;

    public static CarGarage instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        SecondNextButton.gameObject.SetActive(false);
        ThirdNextButton.gameObject.SetActive(false);

        Select2.gameObject.SetActive(false) ;
        Select3.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    //-----------NEXT BUTTONS------------

    public void NextButton()
    {
        
        if (myCamera.transform.position.x <= CameraPos1.transform.position.x  && myCamera.transform.position.x < CameraPos3.transform.position.x)
        {
            myCamera.transform.position = CameraPos2.transform.position;
            Debug.Log("to pos2");

        }
        FirstNextButton.gameObject.SetActive(false);
        SecondNextButton.gameObject.SetActive(true);
        ThirdNextButton.gameObject.SetActive(false);

        Select1 .gameObject.SetActive(false);
        Select2.gameObject.SetActive(true);
        Select3.gameObject.SetActive(false);


    }
    public void NextButton2()
    {

        if (myCamera.transform.position.x <= CameraPos2.transform.position.x && myCamera.transform.position.x > CameraPos1.transform.position.x)
        {
            myCamera.transform.position = CameraPos3.transform.position;
            Debug.Log("to pos3");


        }
        SecondNextButton.gameObject.SetActive(false);
        FirstNextButton.gameObject.SetActive(false);
        ThirdNextButton.gameObject.SetActive(true);

        Select1.gameObject.SetActive(false);
        Select2.gameObject.SetActive(false);
        Select3.gameObject.SetActive(true);

    }
    public void NextButton3()
    {
        if (myCamera.transform.position.x == CameraPos3.transform.position.x && myCamera.transform.position.x > CameraPos1.transform.position.x)
        {
            myCamera.transform.position = CameraPos1.transform.position;
            Debug.Log("to pos1");


        }
        FirstNextButton.gameObject.SetActive(true);
        SecondNextButton.gameObject.SetActive(false);
        ThirdNextButton.gameObject.SetActive(false);

        Select1.gameObject.SetActive(true);
        Select2.gameObject.SetActive(false);
        Select3.gameObject.SetActive(false);

    }

    //----------SELECT BUTTONS----------

    public void SelectButton1()
    {
        carNumber = 0;
        SceneManager.LoadScene(6);
        Debug.Log(carNumber);

    }

    public void SelectButton2()
    {
        carNumber = 1;
        SceneManager.LoadScene(6);
        Debug.Log(carNumber);

    }

    public void SelectButton3()
    {
        carNumber = 2;
        SceneManager.LoadScene(6);
        Debug.Log(carNumber);
    }
}
