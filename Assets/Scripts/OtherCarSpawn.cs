using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OtherCarSpawn : MonoBehaviour
{
    public GameObject[] otherCars;
    public GameObject[] lanes;
    int index1, index2;
    int rand1, rand2;
    public int speed;
    //public float spawnRepeat;

   
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating(nameof(CarsSpawner), 1f, UnityEngine.Random.Range(2f,3f));

    }

    // Update is called once per frame

   

    void Update()
    {
        


    }

    public void CarsSpawner()
    {
        index1 = UnityEngine.Random.Range(0, otherCars.Length);
        index2 = UnityEngine.Random.Range(0, lanes.Length);

        Instantiate(otherCars[index1], lanes[index2].transform.position, Quaternion.identity);

        //CancelInvoke("CarsSpawner");

        // InvokeRepeating(nameof(CarsSpawner), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10));

    }

}
