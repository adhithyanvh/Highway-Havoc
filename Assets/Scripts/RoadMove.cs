using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    public GameObject road1,road2,road3;
    public GameObject point1, point2;

    public int scoreChecker;
    public float theScore;
    public bool isLarge =false;

    private void Start()
    {
        scoreChecker = 300;
    }
    private void Update()
    {
        if(road1.transform.position.z <= point1.transform.position.z)
        {
            road1.transform.position = point2.transform.position;
        }
        if (road2.transform.position.z <= point1.transform.position.z)
        {
            road2.transform.position = point2.transform.position;
        }
        if (road3.transform.position.z <= point1.transform.position.z)
        {
            road3.transform.position = point2.transform.position;
        }

        theScore = ScoreUpdater.instancee.score;

        if ( theScore >= scoreChecker  && isLarge == false )
        {
            Debug.Log("working");
            point2.transform.position = new Vector3(point2.transform.position.x,point2.transform.position.y,point2.transform.position.z - 1f);
            isLarge = true;
            scoreChecker = scoreChecker * 2;
        }
        isLarge = false;
    }

}

