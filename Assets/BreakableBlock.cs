using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{

    public GroundCheck2 groundCheckScript;
    public bool destroy = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (groundCheckScript.canSlam == false)
        {
            destroy = true;
            groundCheckScript.canSlam = true;
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        if (destroy == true)
        {
            Destroy(gameObject);
        }
    }
}
