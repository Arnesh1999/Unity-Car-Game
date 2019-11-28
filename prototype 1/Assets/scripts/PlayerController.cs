using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private vriables
    private float speed = 10.0f;
    private float turnspeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    
   
   
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");



        // we'll move vehicle forward

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // to turn a vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
        
    }
}
