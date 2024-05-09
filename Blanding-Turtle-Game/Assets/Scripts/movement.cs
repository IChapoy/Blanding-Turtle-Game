using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100f;
   

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    

    void FixedUpdate()
    {
        Vector2 NoMovement = new Vector2(0f, 0f);

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        if (moveHorizontal > 0)
        {
                rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }
        
        if (moveHorizontal < 0)
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
        }
        if (moveHorizontal == 0) {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        /*float moveVertical = Input.GetAxisRaw("Vertical");
        if (moveVertical == 0) { new Vector2(0, rb2d.velocity.x); }
        if (moveVertical > 0) {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.x);
        } else
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.x);
        } */
        
    }

}
