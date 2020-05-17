using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool running = false;
    bool idle = true;

    // Update is called once per frame
    void Start()
    {
        controller = GetComponent<PlayerController>();
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            running = true;
            
        }
        else
        {
            running = false;
        }
        animator.SetBool("running", running);
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }        
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }                
    }
    
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
