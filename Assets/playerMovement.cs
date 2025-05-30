using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSmoothTime = 0.1f;
    Vector2 inputDirection;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float friction;
    float currentAngle;
    float velocitySmooth;
    bool frictionOn;
    bool playerIsMoving;

    void Start()
    {
        
    }

    void Update()
    {
       

        inputDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;


        if (inputDirection != Vector2.zero)
        {
            playerIsMoving = true;

            float targetAngle = Mathf.Atan2(inputDirection.y, inputDirection.x) * Mathf.Rad2Deg;

         
            currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref velocitySmooth, rotationSmoothTime);

          
            transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);
        }
        else { playerIsMoving = false; }
        
    }

    void FixedUpdate()
    {

        if(playerIsMoving == true)
        {
            rb.velocity += inputDirection.normalized * moveSpeed * Time.fixedDeltaTime;  
        }
        else {rb.velocity = new Vector2(rb.velocity.x * (1 - friction * Time.fixedDeltaTime), rb.velocity.y * (1 - friction * Time.fixedDeltaTime)); }
       
        
    }
}