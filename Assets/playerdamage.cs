using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // 데미지를 받는 함수
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }

        Debug.Log("플레이어 체력: " + currentHealth);
    }

    void Die()
    {
        Debug.Log("플레이어 사망");
        // 여기서 게임 오버 처리하면 됨
        // Destroy(gameObject);
    }
}
