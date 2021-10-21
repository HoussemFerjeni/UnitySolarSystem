using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunmvt : MonoBehaviour
{
public float Daylength;
float _rotationspeed;

    // Update is called once per frame
    void Update()
    {
        _rotationspeed = Time.deltaTime / Daylength;
        transform.Rotate(0,_rotationspeed,0);
    }
}
