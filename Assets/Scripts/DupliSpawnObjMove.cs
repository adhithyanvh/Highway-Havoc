using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupliSpawnObjMove : MonoBehaviour
{
    public float otherCarSpeed;
    public DupliRoadMoveOnly roadMove;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Translate(Vector3.forward * speed*5 * Time.deltaTime);
        speed = speed + 0.0001f;
*/
        /*if (ScoreUpdater.instancee.score >= 5 && DupliRoadMoveOnly.instanceee.speed >30)
        {
            speed = speed + 0.001f;
        }
        */
        float spawnCarSpeed = roadMove.speed;
        otherCarSpeed = -spawnCarSpeed;

        transform.Translate(otherCarSpeed * Time.deltaTime * Vector3.back);

    }
}
