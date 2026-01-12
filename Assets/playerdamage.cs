using UnityEngine;

public class playerdamage : MonoBehaviour
{
    public int health = 5;
    public Rigidbody2D rb;
    public float location = 0;
    public HeartSystem heartSystem;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("health: " + health);
        if (collision.gameObject.CompareTag("monster")) 
        {
            heartSystem.GetDamage(1);
        }
        


    }
}

