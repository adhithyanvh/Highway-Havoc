using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUpdater : MonoBehaviour
{

    public static ScoreUpdater instancee;
    public float score = 0;

    public float timee;

    // Start is called before the first frame update
    void Start()
    {
        instancee = this;

    }

    // Update is called once per frame
    void Update()
    {
        timee += Time.deltaTime;
        if(Time.deltaTime < timee)
        {
            score = score + 0.01f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("OtherCar"))
        {
            

            Destroy(other.gameObject);
        }
    }
}
