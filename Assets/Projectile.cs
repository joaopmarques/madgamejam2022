using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

  public int gunDamage = 1;
  public float hitForce = 100f;

  public AudioSource audioSource;
  public AudioClip shootClip;
  public float shootVol = 0.5f;

  public GameObject impactVFX;

  private bool collided;
  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Player" && !collided)
    {
      collided = true;

      var impact = Instantiate(impactVFX, collision.contacts[0].point, Quaternion.identity) as GameObject;

      if (collision.gameObject.tag == "Enemy") {
        ShootableBox health = collision.gameObject.GetComponent<ShootableBox>();
        if (health != null)
        {
          health.Damage(gunDamage);
          audioSource.PlayOneShot(shootClip, shootVol);
        }
      }

      Destroy(impact, 2);

      Destroy(gameObject);
    }
  }
}
