using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 25;
    private Rigidbody2D rb2d;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        if (transform.position.y < -4.5)
        {
            transform.position = new Vector2(transform.position.x, -4.5f);
        }
        if (transform.position.y > 4.5)
        {
            transform.position = new Vector2(transform.position.x, 4.5f);
        }
    }
    
}