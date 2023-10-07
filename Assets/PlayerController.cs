using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
  public float speed =  7;      // Hareket hyzy

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    

    if(Input.GetKey(KeyCode.LeftShift))
    {
        speed = 16;
    }

    else
    {
        speed = 7;
    }

    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  // A ve D için
        float moveVertical = Input.GetAxis("Vertical");  // W ve S için

        // Hareket yönü
        Vector3 moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        // Oyuncunun bakty?y yönle çarpma
        Vector3 finalMove = transform.TransformDirection(moveDirection) * speed;

        rb.velocity = new Vector3(finalMove.x, rb.velocity.y, finalMove.z);
    }

    
    }

