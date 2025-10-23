using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Movetest : MonoBehaviour
{
    public float runspeed;
    Rigidbody rb;
    Animator animator;
    bool facingRight;
    bool grounded = false;
    public float JumpHeight;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move * runspeed, rb.velocity.y, 0);

        if(move>0 && !facingRight)
        {
            flip();
        }
        else if(move<0 && facingRight)
        {
            flip();
        }

    }

    private void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
        
        
    }

}
