using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    private float _rotationSpeed = 80f;
    private Vector3 _horizontalMovement;
    private float _rotationdirection = 1f;
    private int timer = 0;
    public LaserStopper laserstopperScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = new Vector3(0f ,0f, _rotationdirection);
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        

        //Debug.Log(gameObject.transform.localEulerAngles.z);


       if (laserstopperScript.pressed==false)
        {
            transform.Rotate(_horizontalMovement * _rotationSpeed * Time.deltaTime);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);

            if (hit)
            {

                Debug.Log("Detected " + hit.collider.name);
                if (hit.collider.CompareTag("Laserable"))
                {
                    Debug.Log("We Caught One: " + hit.collider.name);
                }
            }

        }
        else
        {
            timer += 1;

        

            if (timer>=240)
            {
                laserstopperScript.pressed = false;
                transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
                timer = 0;
            }
        }
        
    }
}
