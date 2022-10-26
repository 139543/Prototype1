using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float horizontalInput = 0;
    private float forwardInput = 0;
    
    //I chose to leave speed/turnSpeed public. What if it's attached to another object, such as a motorcycle?
    public float speed = 20; 
    public float turnSpeed = 20;
    public string horizontalAxisName = "HorizontalP1";
    public string verticalAxisName = "VerticalP1";
    void Update() {
        //get inputs
        horizontalInput = Input.GetAxis(horizontalAxisName);
        forwardInput = Input.GetAxis(verticalAxisName);

        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //alternate method
        //GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * speed * forwardInput, ForceMode.VelocityChange);
        
        //rotate vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
