using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Points pointScript;
    public float m_Red, m_Blue, m_Green;
    private float tick = 0;

    public GameObject myDoor;
    public bool myExit;
    public GameObject endText;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (myExit==false)
        {
            Destroy(myDoor);
            Destroy(gameObject);

        }
        else
        {
            if (pointScript.points>=15)
            {
                endText.SetActive(true);
                Destroy(gameObject);
            }
            
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //Start Yellow
        m_Red = 255;
        m_Blue = 0;
        m_Green = 255;

        tick = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //tick += 1;
        transform.Rotate(new Vector3(0, 0, 60) * Time.deltaTime);

     
        



       // mySpriteRenderer.color = new Color(m_Red, m_Green, m_Blue, 1);
    }
}
