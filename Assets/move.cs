using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float x = 0;
    float y = 0;
    float speed = 2;
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
        /*
        else if (Input.GetKey(KeyCode.Space))
        {
            rb2D.AddForce(new Vector2(0, 100));
        }
        */
        rb2D.velocity = new Vector2(x, 0);



    }
}
