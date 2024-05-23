using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dive : MonoBehaviour
    // WORK IN PROGRESS
{
    public Boolean dive = false;
    public GameObject turtle;
    private Collider2D coli;
    void Diving()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dive = true;
            turtle.GetComponent<Collider2D>().enabled = false;
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
