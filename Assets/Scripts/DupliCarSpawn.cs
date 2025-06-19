using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DupliCarSpawn : MonoBehaviour
{
    public GameObject[] otherCars;
    public GameObject[] lanes;
    int index1, index2;
    int rand1, rand2;
    public int speed;
    public bool inLaneTwo;
    //public float spawnRepeat;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating(nameof(CarsSpawner), 1f, UnityEngine.Random.Range(2f, 3f));

    }

    // Update is called once per frame



    void Update()
    {

    }

        public void CarsSpawner()
        {
            index1 = UnityEngine.Random.Range(0, otherCars.Length);
            index2 = UnityEngine.Random.Range(0, lanes.Length);

            GameObject spawnedCar = Instantiate(otherCars[index1], lanes[index2].transform.position, lanes[index2].transform.rotation);

            DupliSpawnObjMove carMovement = spawnedCar.GetComponent<DupliSpawnObjMove>();

            //which lane car is in
            if (carMovement != null)
            {
                carMovement.isRightLane = (index2 == 1); // true = lane 2 (right), false = lane 1 (left)
            }
        }


    }


