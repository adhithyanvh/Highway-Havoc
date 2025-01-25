using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpwnObj : MonoBehaviour
{
    public float otherCarspeed;
    public RoadMoveOnly roadMoveOnly;
    

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        otherCarspeed = UnityEngine.Random.Range(roadMoveOnly.speed - 30f , roadMoveOnly.speed + 10 );

        transform.Translate(otherCarspeed* Time.deltaTime * Vector3.back);

        
       


        //Debug.Log("Other Vehicles Speed =" + otherCarspeed);
    }


    
}
