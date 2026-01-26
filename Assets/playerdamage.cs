using System.Linq;
using UnityEngine;
using System.Collections;

public class playerdamage : MonoBehaviour
{
    public int health = 5;
    public Rigidbody2D rb;
    public float location = 0;
    public HeartSystem heartSystem;
    private bool canDmg = true;
    private SpriteRenderer spriteRenderer;
    public BoxCollider2D box;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer=GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("health: " + health);

        if (collision.gameObject.CompareTag("monster")&&canDmg) 
        {
            canDmg = false;
            box.isTrigger = true;
            heartSystem.GetDamage(1);
            StartCoroutine("Invincibility");

        }
    }
    public void missing() {
        canDmg = false;
        box.isTrigger = true;
    StartCoroutine("Invincibility");
    }
    IEnumerator Invincibility()
    {
        for (int i = 0; i < 10f; i++)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);


        }
        canDmg = true;
        box.isTrigger = false;
        yield return null;
    }
}

