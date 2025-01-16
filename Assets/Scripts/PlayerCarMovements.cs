using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerCarMovements : MonoBehaviour
{

    public GameObject Playerr;
    public GameObject lane1, lane2;
    public float speedOfTurn;

    public GameObject[] OtherCars;
    public GameObject[] Lanes;

    public GameObject[] PlayerCars;
    //public GameObject car1, car2, car3;

    public float offset;
    public float speed;

    

    //public CarGarage CarGarage;

    // Start is called before the first frame update
    void Start()
    {
        if (CarGarage.instance.carNumber == 0)
        {
            Instantiate(PlayerCars[CarGarage.instance.carNumber], Playerr.transform.position, Quaternion.identity);

        }

        if (CarGarage.instance.carNumber == 1)
        {
            Instantiate(PlayerCars[CarGarage.instance.carNumber], Playerr.transform.position, Quaternion.identity);

        }

        if (CarGarage.instance.carNumber == 2)
        {
            Instantiate(PlayerCars[CarGarage.instance.carNumber], Playerr.transform.position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        

        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            //PlayerCar.transform.position = lane2.transform.position;
            PlayerCars[CarGarage.instance.carNumber].transform.position = Vector3.MoveTowards(PlayerCars[CarGarage.instance.carNumber].transform.position,lane2.transform.position,speedOfTurn);

                *//*if (PlayerCar.transform.rotation.y <= 2f && PlayerCar.transform.rotation.y >= 0)
                {
                    PlayerCar.transform.Rotate(0, -0.2f, 0);

                    if(PlayerCar.transform.position == lane2.transform.position)
                    {
                        PlayerCar.transform.rotation = lane1.transform.rotation;

                    }
                }
*//*

            

        }
        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // PlayerCar.transform.position = lane2.transform.position;
            PlayerCars[CarGarage.instance.carNumber].transform.position = Vector3.MoveTowards(PlayerCars[CarGarage.instance.carNumber].transform.position, lane1.transform.position, speedOfTurn);
            
                *//*if(PlayerCar.transform.rotation.y <= 0 && PlayerCar.transform.rotation.y >= 2f)
                {
                    PlayerCar.transform.Rotate(0, -0.2f, 0);
                    if (PlayerCar.transform.position == lane1.transform.position)
                    {
                        PlayerCar.transform.rotation = lane1.transform.rotation;

                    }
                }*//*

            

        }*/

    }



    /* private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.CompareTag("OtherCar"))
         {
             Destroy(gameObject);
             Debug.Log("hittt");
         }
     }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OtherCar"))
        {
            Destroy(gameObject);
            Debug.Log("deaddd");
        }
    }
}
