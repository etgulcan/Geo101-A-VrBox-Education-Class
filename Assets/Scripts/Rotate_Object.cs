using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Object : MonoBehaviour
{

        void Update ()
    {
        transform.Rotate (0,0,25*Time.deltaTime); //rotates 50 degrees per second around z axis
        transform.Rotate (0,50*Time.deltaTime,0);
    }
}
