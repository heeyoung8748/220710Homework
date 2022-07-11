using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float propellerSpeed = 0.0f;


    void Update()
    {
        if(Input.GetKey(KeyCode.W) && propellerSpeed < 60f)
        {
            propellerSpeed += 0.05f;
        }
        else
        {
            if(propellerSpeed > 0)
            {
                propellerSpeed -= 0.006f;
            }
        }
        transform.Rotate(new Vector3(0, propellerSpeed / 10, 0));
    }
}
