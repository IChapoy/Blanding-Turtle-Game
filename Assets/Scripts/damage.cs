using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "player")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
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
