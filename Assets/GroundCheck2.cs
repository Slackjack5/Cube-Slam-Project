using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck2 : MonoBehaviour
{
    public bool isGrounded;
    public bool canSlam = true;
    public bool launched = false;

    public void OnTriggerStay2D(Collider2D other)
    {
        isGrounded = true;
        canSlam = true;
        launched = false;
    }

    public void OnTriggerExit2D()
    {
        isGrounded = false;
        
    }
}
