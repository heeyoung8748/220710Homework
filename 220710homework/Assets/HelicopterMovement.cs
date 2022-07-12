using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovement : MonoBehaviour
{
     private HelicopterInput _input;
    public Rigidbody _playerRigidBody;
    public float speed = 0.01f;
    public bool UseSpeed = false;
    void Start()
    {
        _input = GetComponent<HelicopterInput>();
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xSpeed = _input.X * speed;
        float zSpeed = _input.Z * speed;
        float ySpeed = _input.Y * speed;
     if(UseSpeed)
        {
            _playerRigidBody.velocity = new Vector3(xSpeed, ySpeed, zSpeed); // 어느 방향으로 속도를 줄 것인가?
        }
        else
        {
            _playerRigidBody.AddForce(xSpeed, ySpeed, zSpeed);
        }
    }
}
