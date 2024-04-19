using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    
    
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        
        
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        if (horizontalInput <= -0.5f)
        {
            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
        if (horizontalInput >= 0.5f)
        {
            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}

//fiakkas
//Kyriacou
//Matthew
//Giorgos K.
//Marinos G