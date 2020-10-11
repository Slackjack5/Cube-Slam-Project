using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck2 : MonoBehaviour
{
    public bool isGrounded;
    public bool canSlam = true;
    public bool launched = false;
    private float particleTimer = 0;

    public GameObject splashParticles;
    public GameObject trailParticles;

    public void OnTriggerStay2D(Collider2D other)
    {

        if (canSlam == false)
        {
            Splash();
        }

        Trail();
        isGrounded = true;
        canSlam = true;
        launched = false;
    }

    public void OnTriggerExit2D()
    {
        isGrounded = false;
    }

    void Splash()
    {
        GameObject splash = Instantiate(splashParticles, gameObject.transform.position, Quaternion.identity);
        splash.GetComponent<ParticleSystem>().Play();

    }

    void Trail()
    {
        //particleTimer++;
        //GameObject trail = Instantiate(trailParticles, gameObject.transform.position, Quaternion.identity);
        /*
        if (particleTimer>=45)
        {
            trail.GetComponent<ParticleSystem>().Play();
            particleTimer = 0;
        }
        if (isGrounded == false)
        {
            trail.GetComponent<ParticleSystem>().Stop();
            particleTimer = 0;
        }
        */
    }
}
