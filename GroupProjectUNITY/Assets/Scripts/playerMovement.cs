using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float playerspeed = 10f;
    public float jumpspeed = 200f;
    public bool isonground;
    public Rigidbody rb;
    public Animator animator;
    bool ismoving;
    bool isfacingRight;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isfacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
        PlayerJump();
        animator = gameObject.GetComponent<Animator>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isonground = true;
        }
    }

    private void playerMove()
    {
        if(Input.GetKeyDown("d"))
        {
            rb.velocity = new Vector3(playerspeed, 0, 0);
            animator.SetBool("ismoving", true);
            
        }
        else if(Input.GetKeyDown("a"))
        {
            
            rb.velocity = new Vector3(-playerspeed, 0, 0);
            animator.SetBool("ismoving", true);
            
        }
        else
        {
            animator.SetBool("ismoving", false);
        }
    
    
    }

    private void PlayerJump()
    {
        
        
            if(Input.GetKey("w") && isonground == true)
            {
                rb.AddForce(new Vector3(0, jumpspeed,0), ForceMode.Impulse);
                isonground=false;
                animator.SetBool("ismoving", true);
            }
           



    }



}
