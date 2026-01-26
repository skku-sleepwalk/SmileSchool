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
    Transform Pos;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Pos = transform;
    }

    // Update is called once per frame
    void Update()
    {
        x = 0;
        y = 0;

        if (Pos.position.x < 11.30851)
        {
            if (Input.GetKey("right"))
            {
                
                x += speed;
            }
        }

        if (Pos.position.x > -8.127645)   
        {
            if (Input.GetKey("left"))
            {
                x -= speed;

            }
        }
        
     
        
        rb2D.velocity = new Vector2(x, rb2D.velocity.y);



    }
}
