using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour
{

  public AudioSource audioSource;
  public AudioClip hitClip;
  public float hitVol = 0.5f;
  public AudioClip deadClip;
  public float deadVol = 0.5f;

  //The box's current health point total
  public int currentHealth = 3;

  public void Damage(int damageAmount)
  {
    //subtract damage amount when Damage function is called
    currentHealth -= damageAmount;
    audioSource.PlayOneShot(hitClip, hitVol);

    //Check if health has fallen below zero
    if (currentHealth <= 0)
    {
      audioSource.PlayOneShot(deadClip, deadVol);
      // if health has fallen below zero, deactivate it 
      Destroy(gameObject, deadClip.length);
    }

  }

}