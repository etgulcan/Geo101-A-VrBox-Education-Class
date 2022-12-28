using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
   
    public GameObject Panel;

    public Vector2 turn;

    public float sensitivity = .05f;

    public Vector3 deltaMove;

    public float speed = 1;

    void Start()

    {

        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()

    {
        if(Panel.activeSelf)
        {
            Quaternion.Euler(0, transform.rotation.y, transform.rotation.z);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            
            turn.x += Input.GetAxis("Mouse X") * sensitivity;

            turn.y += Input.GetAxis("Mouse Y") * sensitivity;

            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        }
        
    }


}
