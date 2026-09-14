using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("player health: " + health);

        if (health <= 0 )
        {
            Debug.Log("Player Died");
        }
    }

    public void Heal(int amount)
    {
        health += amount;
    }
}
