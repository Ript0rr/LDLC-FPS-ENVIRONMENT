using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.name == "Fox") 
            {
                print("Hit renard");
            }
        }
    }
}
