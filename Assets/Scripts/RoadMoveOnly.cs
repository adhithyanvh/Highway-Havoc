using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoveOnly : MonoBehaviour
{
    public float speed = 50;
    public float speedIncreaseRate = 3f; // Rate at which the speed increases
    public float timeBetweenIncreases = 0.1f; // Time in seconds between speed increases
    public float brakeFactor = 5f; // Speed reduction when the brake is applied
    private float timeElapsed = 0f;

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
            speed += speedIncreaseRate;
            timeElapsed = 0f; // Reset the timer
        }

        // Brake: When the space key is pressed, reduce speed
        if (Input.GetKey(KeyCode.Space))
        {
            speed -= brakeFactor * Time.deltaTime; // Apply the brake gradually
            if (speed < 40) speed = 40; // Prevent speed from going negative
        }

        // Move the object
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        //Debug.Log("Road Speed : " + speed);
    }
}
