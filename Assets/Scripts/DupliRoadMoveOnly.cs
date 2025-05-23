


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupliRoadMoveOnly : MonoBehaviour
{

    public float speed = 45;
    public float speedIncreaseRate = 0.1f, speedIncreaseRate2 = 4f; // Rate at which the speed increases
    public float timeBetweenIncreases = 2f; // Time in seconds between speed increases
    private float timeElapsed = 0f;
    public float brakeFactor = 20f; // Speed reduction when the brake is applied


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Increase speed over time
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeBetweenIncreases)
        {
            if(speed >= 45)
            {
                speed += speedIncreaseRate;
            }
            if (speed < 45)
            {
                speed += speedIncreaseRate2;
            }
                timeElapsed = 0f; // Reset the timer
        }

        // Brake: When the space key is pressed, reduce speed
        if (Input.GetKey(KeyCode.Space))
        {
            speed -= brakeFactor * Time.deltaTime; // Apply the brake gradually
            if (speed < 20) speed = 20; 
            
        }
        
        // Move the object
        transform.Translate(Vector3.back * speed * Time.deltaTime);

       Debug.Log("Road Speed : " + speed);
    }
}