using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    public GroundCheck2 groundCheckScript;
    public Rigidbody2D playerRigidBody;
    public bool launched = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (groundCheckScript.canSlam == false && groundCheckScript.launched ==false)
        {
            groundCheckScript.isGrounded = false;
            groundCheckScript.launched = true;
            groundCheckScript.canSlam = false;
            playerRigidBody.AddForce(Vector2.up * 150f, ForceMode2D.Impulse);
        }
    }   

        // Update is called once per frame
        void Update()
        {   

        }
}
