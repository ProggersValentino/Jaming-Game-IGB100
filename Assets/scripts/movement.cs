using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [Header("movement")] 
    public float moveSped;

    public Transform orientation;
    private float horiInput;
    private float vertInput;

    private Vector3 moveDirection;

    private Rigidbody rb;

    public float groundDrag;
    
    [Header("Ground check")] 
    public float playerHei;

    public LayerMask whatIsGround;
    private bool grounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Start()
    {
        moveDirection.y = 0;
        //necessary references 
        
        
        // playerHei = gameObject.transform.localScale.y;
    }

    private void Update()
    {
        //checking to see if player is grounded
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHei * 0.5f + 0.2F, whatIsGround);
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else rb.drag = 0;
        spedCon();
        // myInput();
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    // void myInput()
    // {
    //     
    // }

    void movePlayer()
    {
        //setting the inputs to use unity old input system 
        horiInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");
        
        moveDirection = orientation.forward * vertInput * Time.fixedDeltaTime + orientation.right * -horiInput; //calculating the orientation for the player for the force   
        rb.AddForce(moveDirection.normalized * moveSped * 10f, ForceMode.Impulse);
    }

    void spedCon()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        
        //limit velo
        if (flatVel.magnitude > moveSped)
        {
            Vector3 limitedVel = flatVel.normalized * moveSped;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
