using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    public float speed;
    public float rotationSpeed;
    private float verticalInput;

    //fixed update to run smoothly despite framerate
    void FixedUpdate() {
        // get the user's vertical input (i renamed it for the driving thing)
        verticalInput = Input.GetAxis("VerticalP1");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}
