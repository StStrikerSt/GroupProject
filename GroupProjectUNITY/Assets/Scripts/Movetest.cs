using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Movetest : MonoBehaviour
{
    public float runspeed;
    Rigidbody rb;
    Animator animator;
    bool facingRight;
    public bool grounded = false;
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


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("Ground"))
        {
            grounded = true;
        }
    }
    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move * runspeed, rb.velocity.y, 0);

        if(grounded && Input.GetAxis("Jump")>0)
        {
            rb.AddForce(new Vector3(0, JumpHeight, 0));
            grounded = false;
        }

        if(move>0 || move<0)
        {
            animator.SetBool("ismoving", true);
        }
        else if(move == 0)
        {
            animator.SetBool("ismoving", false);
        }


        if (move > 0 && !facingRight)
        {

            flip();

        }
        else if (move < 0 && facingRight)
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
