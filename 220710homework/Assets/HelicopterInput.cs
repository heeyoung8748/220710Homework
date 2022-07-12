using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterInput : MonoBehaviour
{
    public bool UP { get; private set; }
    public bool DOWN { get; private set; }
    public bool LEFT { get; private set; }
    public bool RIGHT { get; private set; }
    
    public float X {get; private set;}
    public float Y {get; private set;}
    public float Z {get; private set;}

    void Update()
    {
        X = Y = Z = 0.0f;

            X = Input.GetAxis("Horizontal");
            Y = Input.GetAxis("Vertical");
            
    }
}
