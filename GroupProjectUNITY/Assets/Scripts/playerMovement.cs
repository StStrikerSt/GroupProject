using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    float playerspeed = 1f;
    float jumpspeed = 50f;
    public bool isonground;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
        PlayerJump();
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
        if(Input.GetKey("d"))
        {
            transform.Translate(playerspeed, 0, 0);
        }
        else if(Input.GetKey("a"))
        {
            transform.Translate(-playerspeed, 0, 0);
        }
        
    
    
    }

    private void PlayerJump()
    {
        
        
            if(Input.GetKey("w") && isonground == true)
            {
                rb.AddForce(new Vector3(0, jumpspeed,0), ForceMode.Impulse);
                isonground=false;
            }
            
        
    }



}
