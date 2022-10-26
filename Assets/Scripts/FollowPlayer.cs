using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    //object to track
    public GameObject player;
    
    //camera offsets
    public Vector3 offset1 = new Vector3(0, 5, -7);
    public Vector3 offset2 = new Vector3(0, 1, 3);
    
    private Vector3 current_offset;

    //button to switch offsets
    public string camera_angle_switch_input = "CamSwitch1";

    void Start() {
        current_offset = offset1;
    }

    //LateUpdate is used to avoid a race between movement and camera positioning.
    void LateUpdate() {
        //switches offset if button is pressed
        if(Input.GetButtonDown(camera_angle_switch_input)) {
            if(current_offset == offset1) {
                current_offset = offset2;
            } else {
                current_offset = offset1;
            }
        }

        //moves behind targeted object


        transform.position = player.transform.position;
        
        transform.Translate(current_offset, player.transform);

        //rotate
        transform.rotation = player.transform.rotation;


    }
}
