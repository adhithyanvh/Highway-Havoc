/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoveOnly : MonoBehaviour
{
    public static RoadMoveOnly roadSpeed;
    public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreUpdater.instancee.score >= 5)
        {
            speed = speed + 0.005f;
        }

        transform.Translate(Vector3.back * speed * Time.deltaTime);


        Debug.Log("Road Speed : " + speed);

    }

}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoveOnly : MonoBehaviour
{
    public float speed = 40;
    public float speedIncreaseRate = 0.1f; // Rate at which the speed increases
    public float timeBetweenIncreases = 1f; // Time in seconds between speed increases
    public float brakeFactor = 20f; // Speed reduction when the brake is applied
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
            if (speed < 20) speed = 20; // Prevent speed from going negative
        }

        // Move the object
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        Debug.Log("Road Speed : " + speed);
    }
}
