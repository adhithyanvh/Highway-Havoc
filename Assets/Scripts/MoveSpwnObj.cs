using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpwnObj : MonoBehaviour
{
    public float otherCarspeed;
    public RoadMoveOnly roadMoveOnly;

    public int speedMultiplier = 1;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (roadMoveOnly.speed >= 55)
        {
            Debug.Log("speed more");
            speedMultiplier = 3;
        }
        otherCarspeed = UnityEngine.Random.Range(roadMoveOnly.speed, roadMoveOnly.speed * speedMultiplier);

        transform.Translate(otherCarspeed * Time.deltaTime * Vector3.back);

    }



}
