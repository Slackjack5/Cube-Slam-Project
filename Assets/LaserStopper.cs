using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserStopper : MonoBehaviour
{


    public GroundCheck2 groundCheckScript;
    public Rigidbody2D playerRigidBody;
    public bool pressed = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (groundCheckScript.canSlam == false)
        {
            groundCheckScript.isGrounded = false;
            groundCheckScript.launched = true;
            groundCheckScript.canSlam = false;
            pressed = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
