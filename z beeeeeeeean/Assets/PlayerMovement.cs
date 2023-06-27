using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 

    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 3000 * Time.deltaTime);
        }
    }
}