using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInteract : MonoBehaviour
{
    
    public GameObject Panel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Panel != null)
    {
        Cursor.lockState = CursorLockMode.None;
        Panel.SetActive(true);
    }
        }
    }
}
