using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Points pointsScript;
    public bool touched = false;
    public GameObject myPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pointsScript.points += 1;
        Destroy(gameObject);
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
