using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
  public int damagePerHit;
  public int baselineDamagePerHit = 2;
  public float maxRangeOfDamagePerHit = 0.5f;
  int currentHealth;

  void Update()
  {
    damagePerHit = Mathf.CeilToInt(Random.Range(0f, maxRangeOfDamagePerHit) + baselineDamagePerHit);
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      collision.gameObject.GetComponent<PlayerLife>().currentHealth -= damagePerHit;
    }
  }
}
