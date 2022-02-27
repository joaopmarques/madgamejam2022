using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
  public int damagePerHit;
  public int baselineDamagePerHit = 2;
  public float maxRangeOfDamagePerHit = 0.5f;
  public float pushbackForce = 50.0f;
  public AudioSource audioSource;
  public AudioClip hitClip;
  public float hitVol = 0.5f;

  void Update()
  {
    damagePerHit = Mathf.CeilToInt(Random.Range(0f, maxRangeOfDamagePerHit) + baselineDamagePerHit);
  }

  void Attack()
  {
    GameObject player = GameObject.Find("Player");

    // Deal the player damage
    player.GetComponent<PlayerLife>().currentHealth -= damagePerHit;
    audioSource.PlayOneShot(hitClip, hitVol);

    // Bump the player back
    player.GetComponent<Rigidbody>().AddForce(-(player.transform.forward) * pushbackForce, ForceMode.Impulse);
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      Attack();
    }
  }
}
