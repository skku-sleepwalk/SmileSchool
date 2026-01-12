using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;
    public string name;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerdamage playerHealth = collision.gameObject.GetComponent<playerdamage>();

            if (playerHealth != null)
            {
                //playerHealth.TakeDamage(damage);
            }
        }
    }
}
