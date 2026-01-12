using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float x = 0;
    float y = 0;
    public float speed = 5;
    bool flip = false;
    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = 0;
        y = 0;
        if (Input.GetKey("right"))
        {
            x += speed;
        }
        else if (Input.GetKey("left"))
        {
            x -= speed;

        }
        
     
        
        rb2D.velocity = new Vector2(x, rb2D.velocity.y);



    }
}
