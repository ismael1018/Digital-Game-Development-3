using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int health = 100;
    public Slider healthBar;
    public GameObject gameOverScreen;
    private bool isDead = false;

    void Start()
    {
        health = maxHealth;

        healthBar.maxValue = maxHealth;
        healthBar.value = health;

        gameOverScreen.SetActive(false);
        Time.timeScale = 1f;
    }
    public void TakeDamage(int damage)
    {
        if (isDead)
        {
            return;
        }
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);

        healthBar.value = health;
        Debug.Log("Player health: " + health);

        if (health <= 0)
        {
            GameOver();
        }
    }

    public void Heal(int amount)
    {
        if (isDead)
        {
            return;
        }

        health += amount;
        health = Mathf.Clamp(health, 0, maxHealth);

        healthBar.value = health;
    }

    void GameOver()
    {
        isDead = true;

        Debug.Log("Player Died");

        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}