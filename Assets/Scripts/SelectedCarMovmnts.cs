using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedCarMovmnts : MonoBehaviour
{
    public float speed;
    
    
    Vector3 moveClamp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarMovements();
        
       
     
    }

    public void CarMovements()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        //float VerticalInput = Input.GetAxis("Vertical");
        //float Jumpp = Input.GetAxis("Jump");

        transform.Translate(HorizontalInput * speed * Time.deltaTime, 0, 0);

        moveClamp = transform.position;
        moveClamp.x = Mathf.Clamp(moveClamp.x, 3.4f, 7.5f);
        transform.position = moveClamp;
         
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OtherCar"))
        {
           
                Destroy(gameObject);

                SceneManager.LoadScene(5);
            
        }
    }

}
