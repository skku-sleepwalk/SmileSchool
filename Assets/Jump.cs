using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool isGround = true;
    private Rigidbody2D rb;
    public float jumpForce = 3000f;
    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isGround) {
            isGround = false;
            rb.velocity += new Vector2(0, jumpForce);
        }
    }
  
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            // isGround를 true로 변경
            isGround = true;
        }
    }
}
