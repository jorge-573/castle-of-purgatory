using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public int maxHealth = 100;
  public int currentHealth;
  public HealthBar healthBar;
  public GameOverScreen gameOverScreen;

  // Start is called before the first frame update
  void Start()
  {
    currentHealth = maxHealth;
    healthBar.SetMaxHealth(maxHealth);
  }

  // Update is called once per frame
  void Update()
  {
  
  }

  public void TakeDamage(int damage)
  {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);
    if (currentHealth <= 0)
    {
      this.gameObject.SetActive(false);
      gameOverScreen.Setup();
    }
  }
}
