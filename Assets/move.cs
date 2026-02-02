using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{
    float x = 0;
    float y = 0;
    public float speed = 5;
    bool flip = false;
    Rigidbody2D rb2D;
    Transform Pos;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Pos = transform;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = 0;
        y = 0;
        bool isRun = false;

        if (Pos.position.x < 11.30851)
        {
            if (Input.GetKey("right"))
            {
                isRun = true;
                x += speed;
            }
        }

        if (Pos.position.x > -8.127645)   
        {
            if (Input.GetKey("left"))
            {
                isRun = true;

                x -= speed;

            }
        }
        else
        {
            Pos.position = new Vector2(-8.127645f, Pos.position.y);
        }

        if (isRun == true)
            animator.SetTrigger("run");
        else
            animator.SetTrigger("stop");
        rb2D.velocity = new Vector2(x, rb2D.velocity.y);



    }
}
