using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{

    //public GameObject point1, point2, point3, pointMain, player;
    //public GameObject road1, road2, road3;

    public GameObject road;
    public GameObject pos;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Road changes position on reaching the target position.

        /*if (road1.transform.position.z <= pointMain.transform.position.z)
        {
            road1.transform.position = point3.transform.position;
        }
        if (road2.transform.position.z <= pointMain.transform.position.z)
        {
            road2.transform.position = point3.transform.position;
        }
        if (road3.transform.position.z <= pointMain.transform.position.z)
        {
            road3.transform.position = point3.transform.position;

        }*/

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Road"))
        {

            Instantiate(road, pos.transform.position, road.transform.rotation);
            Debug.Log("eheheheh");
        }

    }
}
