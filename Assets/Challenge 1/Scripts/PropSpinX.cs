using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpinX : MonoBehaviour {
    public float rotationSpeed = 500;

    void Update() {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
