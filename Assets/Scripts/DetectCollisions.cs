using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
       
        if(tag == "Food")
        {
            Destroy(gameObject);
            Dash();
        }
        else if (tag == "Obstacle")
        {

        }
       
    }

    private void Dash()
    {

    }
}