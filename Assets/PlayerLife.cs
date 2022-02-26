using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

  public int maxHealthPoints = 15;
  public int currentHealth;
  GameObject statsManager;

  void Start()
  {
    currentHealth = maxHealthPoints;
    statsManager = GameObject.Find("StatsManager");
  }

  private void Die() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  void Update()
  {
    statsManager.GetComponent<StatsController>().currentHealth = currentHealth.ToString();
    if (currentHealth <= 0)
    {
      Die();
    }
  }
}
