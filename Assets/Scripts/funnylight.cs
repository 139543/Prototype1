using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnylight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float hue = 0;
    void Update()
    {
        GetComponent<Light>().color = Color.HSVToRGB(hue, 1, 1);
        hue += 0.01F;
        hue = hue % 1;
    }
}
