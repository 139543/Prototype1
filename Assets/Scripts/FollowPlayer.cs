using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    //object to track
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    
    //LateUpdate is used to avoid a race between movement and camera positioning.
    void LateUpdate() {
        //moves behind targeted object
        transform.position = player.transform.position + offset;
    }
}
