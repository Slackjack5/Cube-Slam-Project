using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{

    public SpriteRenderer thisSprite;
    public Rigidbody2D thisRigidbody2D;
    public float force = 10f;
   

    public GroundCheck2 groundCheckScript;
    public float gravityInAir;

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (groundCheckScript.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            }

           
            thisRigidbody2D.gravityScale = 1;
        }
        //Ground Slam
        if (groundCheckScript.isGrounded == false && groundCheckScript.canSlam == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.down * force*3, ForceMode2D.Impulse);
                groundCheckScript.canSlam = false;
            }
           

            thisRigidbody2D.gravityScale = 1;
        }

        if (groundCheckScript.isGrounded==false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            thisRigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            thisRigidbody2D.AddForce(-Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }

      
    }
}
