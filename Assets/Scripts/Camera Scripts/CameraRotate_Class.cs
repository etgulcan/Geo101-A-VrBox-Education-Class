using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate_Class : MonoBehaviour
{
    
    public Vector2 turn;

    public float sensitivity = .05f;

    public Vector3 deltaMove;

    public float speed = 1;

    void Start()

    {
        Camera.main.transform.rotation = Quaternion.Euler(0,180,0);
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()

    {
            turn.x += Input.GetAxis("Mouse X") * sensitivity;

            turn.y += Input.GetAxis("Mouse Y") * sensitivity;

            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        
    }
}
