using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DupliCarSpawn : MonoBehaviour
{
    public GameObject[] otherCars;
    public GameObject[] otherCarsOpp;

    public GameObject[] lanes;
    int index1, index2;
    int rand1, rand2;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CarsSpawner),1f, UnityEngine.Random.Range(0, 10));

        InvokeRepeating(nameof(CarSpawnerOpp), 3f, UnityEngine.Random.Range(0, 15));


    }

    // Update is called once per frame



    void Update()
    {
       

    }

    public void CarsSpawner()
    {
        index1 = UnityEngine.Random.Range(0, otherCars.Length);
        Instantiate(otherCars[index1], lanes[1].transform.position, Quaternion.identity);

        CancelInvoke("CarsSpawner");

        InvokeRepeating(nameof(CarsSpawner), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10));

    }

    public void CarSpawnerOpp()
    {
        index2 = UnityEngine.Random.Range(0, otherCars.Length);
        Instantiate(otherCarsOpp[index2], lanes[0].transform.position, Quaternion.Euler(0, 180, 0));

        CancelInvoke("CarSpawnerOpp");

        //Invoke(nameof(CarSpawnerOpp), UnityEngine.Random.Range(0, 10));

        InvokeRepeating(nameof(CarSpawnerOpp), UnityEngine.Random.Range(0, 15), UnityEngine.Random.Range(0, 10));

    }

}
