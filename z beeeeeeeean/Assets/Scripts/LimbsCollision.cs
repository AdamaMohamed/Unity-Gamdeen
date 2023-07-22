using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbsCollision : MonoBehaviour
{
    private PlayerMovment PlayerMovment;

    void Start()
    {
        PlayerMovment = FindObjectOfType<PlayerMovment>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerMovment.isGrounded = true;
    }
}