using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpwnObj : MonoBehaviour
{
    float otherCarspeed;
    public RoadMoveOnly roadMoveOnly;
    //SCORE



    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(otherCarspeed * Time.deltaTime * Vector3.back);

        float spawnCarSpeed = roadMoveOnly.speed;
        otherCarspeed = spawnCarSpeed - 10f;


        //Debug.Log("Other Vehicles Speed =" + otherCarspeed);
    }


    
}
